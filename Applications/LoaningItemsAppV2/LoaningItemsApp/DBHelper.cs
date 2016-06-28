using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LoaningItemsApp
{
    class DBHelper
    {
        public MySqlConnection connection;

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

        public List<Item> GetAllItems()
        {
            String sql = "SELECT * FROM loanitems";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Item> temp;
            temp = new List<Item>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int priceperday;
                string name;
                int loaned;
                DateTime returndate;
                DateTime loandate;
                int article_id;

                while (reader.Read())
                {
                    article_id = Convert.ToInt32(reader["ARTICLE_ID"]);
                    priceperday = Convert.ToInt32(reader["PRICEDAY"]);

                    name = Convert.ToString(reader["NAME"]);

                    loaned = Convert.ToInt32(reader["LoanStatus"]);
                    returndate = Convert.ToDateTime(reader["DUEDATE"]);
                    loandate = Convert.ToDateTime(reader["STARTDATE"]);

                    temp.Add(new Item(article_id,name, loaned,priceperday,returndate, loandate));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }
       
        
        public int CheckIfPaid(string bracelet_id)
        {
            String sql = "SELECT PAID FROM visitors WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
            MySqlCommand command = new MySqlCommand(sql, connection);

            int paid = -1;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    paid = Convert.ToInt32(reader["PAID"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return paid;
        }

        public double getBalance(string bracelet_id)
        {
            double balance = -1;
            String sql = "SELECT BALANCE FROM visitors WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    balance = Convert.ToDouble(reader["BALANCE"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return balance;
        }

        public void UpdateBalance(string bracelet_id, double newBalance)
        {
            double left = (newBalance - Math.Floor(newBalance))*10;
            newBalance = Math.Floor(newBalance);
            String sql = "UPDATE visitors SET BALANCE = " + newBalance.ToString()+"."+left.ToString() + " WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        public void SetStartDate(int articleid)
        {
            
            
            String sql = "UPDATE loanitems SET STARTDATE = " + "NOW()" + " WHERE ARTICLE_ID = ?Article_id;";

            MySqlCommand command = new MySqlCommand(sql, connection);
            command.CommandText = sql;
            command.Parameters.AddWithValue("?Article_id", articleid);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Error updating database");
            }
            finally
            {
                connection.Close();
            }
        }
        public void SetLoanStatus(int articleid, string bracelet_id)
        {
            string sql = "UPDATE loanitems SET LoanStatus = 1, USER_ID = (SELECT visitors.USER_ID FROM visitors WHERE BRACELET_ID = ?bracelet_ID LIMIT 1) WHERE ARTICLE_ID = ?Article_id;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.CommandText = sql;
            command.Parameters.AddWithValue("?Article_id", articleid);
            command.Parameters.AddWithValue("?bracelet_ID", bracelet_id);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        public void SetLoanStatusToFalse(int articleid)
        {
            string sql = "UPDATE loanitems SET LoanStatus = 0, USER_ID = 0 ,RETURNDATE = NOW() WHERE ARTICLE_ID = ?Article_id;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.CommandText = sql;
            command.Parameters.AddWithValue("?Article_id", articleid);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        public void SetDueDate(int articleid, string duedate)
        {


            String sql = "UPDATE loanitems SET DUEDATE = ?DueDate WHERE ARTICLE_ID = ?Article_id;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.CommandText = sql;
            command.Parameters.AddWithValue("?DueDate", duedate);
            command.Parameters.AddWithValue("?Article_id", articleid);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Error updating database");
            }
            finally
            {
                connection.Close();
            }
        }
       




    }
}
