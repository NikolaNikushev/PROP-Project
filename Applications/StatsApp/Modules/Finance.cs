using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Modules
{
    public static class Finance
    {

        //string completeRevenue;
        //string revenueServices;
        //string revenueSales;
        //string balanceCapacityWorth;
        //string tentsTotalSum;
        //string ticketsTotalSum;
        //string mostPopularTicket;
        //string mostPopularStore;

        private static List<string> ExecuteSqlTransaction()
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
                    /////////////////////////////////                  
                    command.CommandText = @"SELECT SUM(PAYSUM) as tent WHERE TYPE = 'TENT'; ";


                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string tentsTotalSum = reader["tent"].ToString();
                        financialValues.Add(tentsTotalSum);
                    }
                    reader.Close();
                    /////add number of updates 
                    /////////
                    command.CommandText = @"SELECT SUM(PAYSUM) ticket WHERE TYPE = 'TICKET'; ";

                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {

                        string ticketsTotalSum = reader["tecket"].ToString();
                        financialValues.Add(ticketsTotalSum);
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
                        string mostPopularTicket = reader["PAYSUM"].ToString();
                        financialValues.Add(mostPopularTicket);
                    }
                    reader.Close();
                    //////////////////////////
                    command.CommandText = @"SELECT COUNT(*),STORE_ID,STORENAME,DESCRIPTION
                                            FROM storepayment JOIN stores
                                            USING(STORE_ID)
                                            GROUP BY STORE_ID
                                            ORDER BY COUNT(*) DESC;";

                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string mostPopularStore = reader["PAYSUM"].ToString();
                        financialValues.Add(mostPopularStore);
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

        public static void PupulateFinanceData(Label[] labels)
        {
            for (int i = 0; i < ExecuteSqlTransaction().Count; i++)
            {
                labels[i].Text = ExecuteSqlTransaction()[i];
            }

        }

    }
}
