using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Modules
{
    class Finance
    {

        private static void ExecuteSqlTransaction(string connectionString)
        {

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
                    }
                    reader.Close();
                    /////////////////////////////////
                    command.CommandText = @"SELECT SUM(PAYSUM) as rev FROM serpayments;";
                    
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string revenueServices = reader["rev"].ToString();
                    }
                    reader.Close();
                    /////////////////////////////////
                    command.CommandText = @"SELECT SUM(TOTALPRICE) as rev FROM storepayment; ";                   
   
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string revenueSales = reader["rev"].ToString();
                    }
                    reader.Close();
                    /////////////////////////////////
                    command.CommandText = @"SELECT SUM(BALANCE) as balance FROM visitors; ";

                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string balanceCapacityWorth = reader["balance"].ToString();
                    }
                    reader.Close();
                    /////////////////////////////////
                    command.CommandText = @"SELECT SUM(PAYSUM) as tent WHERE TYPE = 'TENT'; ";


                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string tentsTotalSum = reader["tent"].ToString();
                    }
                    reader.Close();
                    /////////////////////////////////
                    command.CommandText = @"SELECT SUM(PAYSUM) as tent WHERE TYPE = 'TENT'; ";


                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string tentsTotalSum = reader["tent"].ToString();
                    }
                    reader.Close();
                    /////add number of updates 
                    /////////
                    command.CommandText = @"SELECT SUM(PAYSUM) ticket WHERE TYPE = 'TICKET'; ";

                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string ticketsTotalSum = reader["tecket"].ToString();
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
        }
    }
}
