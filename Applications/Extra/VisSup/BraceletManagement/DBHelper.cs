using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BraceletManagement
{
    public class DBHelper
    {
        private int messageShowTime = 1000;
        public MySqlConnection connection;


        //----------Constructors:
        public DBHelper()
        {
            //String connectionInfo = "server=localhost;" +
            //                        "database=propdbtest;" +
            //                        "user id=root;" +
            //                        "password=;" +
            //                        "connect timeout=30;" +
            //                        "convert zero datetime=True";

            connection = new MySqlConnection(DBConnectionDll.Connection.connectionInfo);
        }
        //----------Methods:

        /// <summary>
        /// Used to prevent some malicious user inputs
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string RemoveWhiteSpaces(string input)
        {
            string output = "";
            char[] tempCharArray = new char[input.Length];
            tempCharArray = input.ToCharArray();
            foreach (char potentialWS in tempCharArray)
            {
                if (potentialWS != ' ' && potentialWS != '\t' && potentialWS != '\n')
                {
                    // if no crap is detected, we can add it into the output string
                    output += potentialWS;
                }
                // ignore the whitespaces and other heresy! 
            }
            // should returned a whitespaceless perfect string
            return output;
        }

        /// <summary>
        /// Returns the status of the requred RFID chip
        /// </summary>
        /// <param name="chipNum"></param>
        /// <returns></returns>
        public StatusTypes.BraceletStatus getRFIDStatus(string chipNum)
        {
            //First we make sure that something meaningful is returned in all cases
            StatusTypes.BraceletStatus valueToReturn = StatusTypes.BraceletStatus.NOT_VALID;


            // Somekind of a protective measure
            chipNum = RemoveWhiteSpaces(chipNum);

            // Some crazy ass db interaction
            String sql = "SELECT * FROM RFIDS WHERE BRACELET_ID =" + " \"" + chipNum + "\" ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["STATUS"] != DBNull.Value)
                    {
                        string recStatus = reader["STATUS"].ToString();

                        // solution from msdn:
                        //Colors colorValue = (Colors) Enum.Parse(typeof(Colors), colorString);     
                        StatusTypes.BraceletStatus bracStatus = (StatusTypes.BraceletStatus)Enum.Parse((typeof(StatusTypes.BraceletStatus)), recStatus);
                        // should create a new instance of a retrieved status for this particular chip
                        valueToReturn = bracStatus;
                    }

                }

            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show(ex.ToString(), "Oups! You can skip it", messageShowTime);
            }
            finally
            {
                connection.Close();
            }


            return valueToReturn;
        }

        /// <summary>
        /// Returns the whole data container for the visitor retrieved by the specified attribute-value pair
        /// If no such visitor is found, returns null
        /// </summary>
        /// <param name="whereClauseAttribute"></param>
        /// <param name="whereClauseValue"></param>
        /// <returns></returns>
        public VisitorData getVisitorData(StatusTypes.SearchType searchAttribute, string whereClauseValue)
        {
            // returns null if there no such email
            VisitorData valueToReturn = null;

            // removing the whitespaces from user input
            whereClauseValue = RemoveWhiteSpaces(whereClauseValue);
            string whereClauseAttribute = searchAttribute.ToString();

            // We need to think of some ways to prevent the sql injections and other messed up user entries
            String sql = "SELECT USER_ID, EMAIL, FNAME, LNAME, SECCODE, BRACELET_ID, STATUS FROM VISITORS WHERE UPPER("
                + whereClauseAttribute + ") =" + " UPPER(\"" + whereClauseValue + "\")";
            MySqlCommand command = new MySqlCommand(sql, connection);


            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // should create a new instance of a DataContainer with retrieved values
                    if (reader["EMAIL"] != DBNull.Value)
                    {
                        string chipNum = "";
                        if (reader["BRACELET_ID"] == DBNull.Value)
                        {
                            chipNum = "NULL";
                        }
                        else
                        {
                            chipNum = (string)reader["BRACELET_ID"];
                        }
                        string seccode = "";
                        if (reader["SECCODE"] == DBNull.Value)
                        {
                            seccode = "N/A";
                        }
                        else
                        {
                            seccode = (string)reader["SECCODE"];
                        }
                        valueToReturn = new VisitorData((int)reader["USER_ID"], (string)reader["EMAIL"], (string)reader["FNAME"], (string)reader["LNAME"],
                                                seccode, chipNum, (int)reader["STATUS"]);
                    }


                }

            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show(ex.ToString(), "Oups!", messageShowTime);
            }
            finally
            {
                connection.Close();
            }


            return valueToReturn;
        }


        /// <summary>
        /// Used to update the visitor data and set it to the new values
        /// </summary>
        /// <param name="newChipData"></param>
        /// <param name="userid"></param>
        /// <param name="email"></param>
        /// <param name="fn"></param>
        /// <param name="ln"></param>
        /// <returns></returns>
        public bool UpdateVisitorData(int userid, string email, string fn, string ln)
        {
            connection.Close();
            connection.Open();
            bool methodResult = false;
            MySqlCommand command = connection.CreateCommand();
            MySqlTransaction transaction;

            // Start a local transaction.
            transaction = connection.BeginTransaction();

            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            command.Connection = connection;
            command.Transaction = transaction;


            try
            {
                //Payment ID
                command.CommandText = "SELECT USER_ID FROM VISITORS WHERE EMAIL = '" + email + "';";
                MySqlDataReader reader = command.ExecuteReader();
                bool emailClash = false;
                while (reader.Read())
                {
                    if (userid != (int)reader["USER_ID"])
                    {
                        emailClash = true;
                    }
                }
                if (emailClash)
                {
                    throw new EmailClashException("Such email already exists");
                }
                reader.Close();
                //UPDATE `visitors` SET `EMAIL`="jf@jf.jf",`FNAME`="Jennifer",`LNAME`="Franklin" WHERE USER_ID = 1137;
                String sql = "UPDATE VISITORS " +
                            "SET EMAIL =" + " \"" + email + "\", " +
                            " FNAME='" + fn + "', " +
                            " LNAME='" + ln + "' " +
                            "WHERE USER_ID =" + " \"" + userid + "\" ";

                command.CommandText = sql;
                int numberOfRowsAffected = command.ExecuteNonQuery();
                if (numberOfRowsAffected != 1)
                {
                    throw new Exception("Something went wrong");
                }

                // Attempt to commit the transaction.
                transaction.Commit();
                methodResult = true;
                Console.WriteLine("All records are written to database.");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);
                // Attempt to roll back the transaction.
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }
            finally
            {
                connection.Close();
            }
            return methodResult;
        }


        public List<Payment> GetPaymentLog(int userId)
        {
            /// SELECT DATE as PAYTIME, TYPE as REASON, PAYSUM as AMOUNT, DESCRIPTION
            /// from serpayments WHERE USER_ID = 1123
            /// UNION
            /// SELECT stp.PURCHASETIME as PAYTIME, s.STORENAME as REASON, stp.TOTALPRICE as SPENT, "Payment in the store"
            /// from storepayment stp JOIN
            /// stores s
            /// on stp.STORE_ID = s.store_id
            /// WHERE USER_ID = 1124 order by DATE
            List<Payment> lp = new List<Payment>();

            // removing the whitespaces from user input


            // We need to think of some ways to prevent the sql injections and other messed up user entries


            string sql = "SELECT DATE as PAYTIME, TYPE as REASON, PAYSUM as AMOUNT, DESCRIPTION" +
            " from serpayments WHERE USER_ID = " + userId +
            " UNION " +
            "SELECT stp.PURCHASETIME as PAYTIME, s.STORENAME as REASON, stp.TOTALPRICE as SPENT, 'Payment in the store' " +
            " from storepayment stp JOIN " +
            " stores s " +
            " on stp.STORE_ID = s.store_id " +
            " WHERE USER_ID = " + userId +
            " order by PAYTIME ;";



            MySqlCommand command = new MySqlCommand(sql, connection);


            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DateTime paytime = Convert.ToDateTime(reader["PAYTIME"]);
                    string reason = (string)reader["REASON"];
                    int amount = Convert.ToInt32(reader["AMOUNT"]);
                    string desc = (string)reader["DESCRIPTION"];
                    //valueToReturn = new VisitorData((int)reader["USER_ID"], (string)reader["EMAIL"], (string)reader["FNAME"], (string)reader["LNAME"],
                    //                        seccode, chipNum, (int)reader["STATUS"]);

                    lp.Add(new Payment(paytime, reason, amount, desc));
                }

            }
            catch (Exception ex)
            {
                //AutoClosingMessageBox.Show(ex.ToString(), "Oups!", messageShowTime);
                MessageBox.Show(ex.ToString(), "Oups!");
            }
            finally
            {
                connection.Close();
            }

            return lp;
        }


    }

}
