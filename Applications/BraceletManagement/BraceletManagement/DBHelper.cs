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
    class DBHelper
    {
        public MySqlConnection connection;


        //----------Constructors:
        public DBHelper()
        {
            String connectionInfo = "server=localhost;" +
                                    "database=propdbtest;" +
                                    "user id=root;" +
                                    "password=;" +
                                    "connect timeout=30;" +
                                    "convert zero datetime=True";

            connection = new MySqlConnection(connectionInfo);
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
                AutoClosingMessageBox.Show(ex.ToString(), "Oups! You can skip it", 300);
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
            String sql = "SELECT EMAIL, FNAME, LNAME, SECCODE, BRACELET_ID, STATUS FROM VISITORS WHERE UPPER("
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
                        valueToReturn = new VisitorData((string)reader["EMAIL"], (string)reader["FNAME"], (string)reader["LNAME"],
                                                (string)reader["SECCODE"], chipNum, (int)reader["STATUS"]);
                    }


                }

            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show(ex.ToString(), "Oups!", 300);
            }
            finally
            {
                connection.Close();
            }


            return valueToReturn;
        }

        public bool DeactivateBracelet(string chipNum, string secCode)
        {
            bool methodResult = false;
            String sql = "UPDATE RFIDS "
                + "SET STATUS = \"DEACTIVATED\""
                + "WHERE BRACELET_ID =" + " \"" + chipNum + "\" ";
            MySqlCommand command = new MySqlCommand(sql, connection);


            try
            {
                connection.Open();
                int affectedRows = 0;
                affectedRows += command.ExecuteNonQuery();
                sql = "UPDATE VISITORS "
                        + "SET BRACELET_ID = NULL"
                        + "WHERE SECCODE =" + " \"" + secCode + "\" ";
                command = new MySqlCommand(sql, connection);
                affectedRows += command.ExecuteNonQuery();
                switch (affectedRows)
                {
                    case 0:
                        methodResult = false;
                        break;
                    //check sum == 2
                    case 2:
                        methodResult = true;
                        break;
                    default:
                        methodResult = false;
                        break;

                }
            }
            catch (Exception ex)
            {
                methodResult = false;
                AutoClosingMessageBox.Show(ex.Message, "Oups!", 300);
            }
            finally
            {
                connection.Close();
            }
            return methodResult;
        }







        // would be nice to make use of delegates somehow
        //static public void GetData(string tableName, string SelectClauseAttribute, string whereClauseAttribute, string whereClauseValue)
        //{
        //    String sql = "SELECT "+ SelectClauseAttribute + " FROM "+ tableName + " WHERE "+ whereClauseAttribute + " = " + "\"" + whereClauseValue + "\"";
        //    MySqlCommand command = new MySqlCommand(sql, connection);
        //    try
        //    {
        //        connection.Open();
        //        MySqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}


        //static public void GetData(int nrRows)
        //{

        //}


    }
}
