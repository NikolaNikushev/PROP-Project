using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Modules
{
    public class Payment
    {// used to store the data about the payments done by the visitor
        //DATE as PAYTIME, TYPE as REASON, PAYSUM as AMOUNT, DESCRIPTION
        public DateTime Paytime
        {
            get; private set;
        }
        public string Reason
        {
            get; private set;
        }
        public int Amount
        {
            get; private set;
        }
        public string Desription
        {
            get; private set;
        }
        /// <summary>
        /// used to store the data about all the payments done by the visitor
        /// including shops and services
        /// </summary>
        /// <param name="paytime"></param>
        /// <param name="reason"></param>
        /// <param name="amount"></param>
        /// <param name="desription"></param>
        public Payment(DateTime paytime, string reason, int amount, string desription)
        {
            this.Amount = amount;
            this.Desription = desription;
            this.Paytime = paytime;
            this.Reason = reason;
        }

        public override string ToString()
        {
            return this.Paytime + ": " + this.Amount + System.Globalization.NumberFormatInfo.CurrentInfo.CurrencySymbol + " at " + this.Reason + "; " + this.Desription;
        }

    }

    public static class Finance
    {



        private static List<string> GlobalDataTransaction()
        {
            List<string> financialValues = new List<string>();


            using (MySqlConnection connection = DBConnectionDll.Connection.connection)
            {
                connection.Open();

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
                    command.CommandText = @"SELECT SUM(revenue) as rev
                                           FROM(SELECT SUM(PAYSUM) as revenue FROM serpayments
                                           UNION
                                           SELECT SUM(TOTALPRICE) FROM storepayment) x; ";

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string completeRevenue = reader["rev"].ToString();
                        financialValues.Add(completeRevenue);
                    }
                    reader.Close();
                    /////////////////////////////////
                    command.CommandText = @"SELECT SUM(PAYSUM) as rev FROM serpayments;";

                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string revenueServices = reader["rev"].ToString();
                        financialValues.Add(revenueServices);
                    }
                    reader.Close();
                    /////////////////////////////////
                    command.CommandText = @"SELECT SUM(TOTALPRICE) as rev FROM storepayment; ";

                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string revenueSales = reader["rev"].ToString();
                        financialValues.Add(revenueSales);
                    }
                    reader.Close();
                    /////////////////////////////////
                    command.CommandText = @"SELECT SUM(BALANCE) as balance FROM visitors; ";

                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string balanceCapacityWorth = reader["balance"].ToString();
                        financialValues.Add(balanceCapacityWorth);
                    }
                    reader.Close();



                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
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
            }
            return financialValues;
        }

        private static List<string> TentsTransaction()
        {
            List<string> financialTentsValues = new List<string>();


            using (MySqlConnection connection = DBConnectionDll.Connection.connection)
            {
                connection.Open();

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

                    command.CommandText = @"SELECT SUM(PAYSUM) as tent FROM serpayments WHERE TYPE = 'TENT'; ";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string tentsTotalSum = "Total money sum of tents: " + reader["tent"].ToString();
                        financialTentsValues.Add(tentsTotalSum);
                    }
                    reader.Close();
                    /////add number of updates 


                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
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
            }
            return financialTentsValues;
        }

        private static List<string> TicketsTransaction()
        {
            List<string> financialTicketsValues = new List<string>();


            using (MySqlConnection connection = DBConnectionDll.Connection.connection)
            {
                connection.Open();

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

                    command.CommandText = @"SELECT SUM(PAYSUM) AS ticket FROM serpayments  WHERE TYPE = 'TICKET'; ";

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string ticketsTotalSum = "Total money sum of tickets: " + reader["ticket"].ToString();
                        financialTicketsValues.Add(ticketsTotalSum);
                    }
                    reader.Close();
                    //////////////////////////
                    command.CommandText = @"SELECT MAX(most), PAYSUM
                                            FROM(
                                            SELECT COUNT(*) AS 'most',PAYSUM
                                            FROM serpayments 
                                            WHERE PAYSUM = 55
                                            UNION
                                            SELECT COUNT(*),PAYSUM
                                            FROM serpayments 
                                            WHERE PAYSUM = 85
                                            UNION
                                            SELECT COUNT(*),PAYSUM
                                            FROM serpayments 
                                            WHERE PAYSUM = 125) x;";

                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string mostPopularTicket = "Cost of the most popular ticket is: " + reader["PAYSUM"].ToString();
                        financialTicketsValues.Add(mostPopularTicket);
                    }
                    reader.Close();


                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
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
            }
            return financialTicketsValues;
        }

        private static List<string> SalesTransaction()
        {
            List<string> financialSalesValues = new List<string>();


            using (MySqlConnection connection = DBConnectionDll.Connection.connection)
            {
                connection.Open();

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

                    command.CommandText = @"SELECT COUNT(*),STORE_ID,STORENAME,DESCRIPTION
                                            FROM storepayment JOIN stores
                                            USING(STORE_ID)
                                            GROUP BY STORE_ID
                                            ORDER BY COUNT(*) DESC;";

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string mostPopularStoreName = "The most popular store: " + reader["STORENAME"].ToString();
                        string mostPopularStoreDescription = reader["DESCRIPTION"].ToString();
                        financialSalesValues.Add(mostPopularStoreName);
                        financialSalesValues.Add(mostPopularStoreDescription);
                    }
                    reader.Close();


                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
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
            }
            return financialSalesValues;
        }

        public static void PupulateGlobalData(Label[] labels)
        {
            for (int i = 0; i < GlobalDataTransaction().Count; i++)
            {
                labels[i].Text = GlobalDataTransaction()[i];
            }

        }
        public static void PopulateTents(TextBox[] textboxes)
        {
            for (int i = 0; i < TentsTransaction().Count; i++)
            {
                textboxes[i].Text = TentsTransaction()[i];
            }
        }
        public static void PopulateTickets(TextBox[] textboxes)
        {
            for (int i = 0; i < TicketsTransaction().Count; i++)
            {
                textboxes[i].Text = TicketsTransaction()[i];
            }
        }
        public static void PopulateSales(TextBox[] textboxes)
        {
            for (int i = 0; i < SalesTransaction().Count; i++)
            {
                textboxes[i].Text = SalesTransaction()[i];
            }
        }
        public static void PopulateLog(ListBox listBox)
        {
            listBox.Items.AddRange(GetPaymentLog().ToArray());
        }

        private static List<Payment> GetPaymentLog()
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
            " from serpayments " +
            " UNION " +
            "SELECT stp.PURCHASETIME as PAYTIME, s.STORENAME as REASON, stp.TOTALPRICE as SPENT, 'Payment in the store' " +
            " from storepayment stp JOIN " +
            " stores s " +
            " on stp.STORE_ID = s.store_id " +
            " order by PAYTIME ;";



            MySqlCommand command = new MySqlCommand(sql, DBConnectionDll.Connection.connection);


            try
            {
                DBConnectionDll.Connection.connection.Open();
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
                DBConnectionDll.Connection.connection.Close();
            }

            return lp;
        }

    }
}
