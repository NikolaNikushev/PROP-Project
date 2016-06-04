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
            String connectionInfo = "server=localhost;" +
                                    "database=propdbtest;" +
                                    "user id=root;" +
                                    "password=;" +
                                    "connect timeout=30;" +
                                    "convert zero datetime=True";

            connection = new MySqlConnection(connectionInfo);
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
                bool loaned;
                DateTime returndate;

                while (reader.Read())
                {

                    priceperday = Convert.ToInt32(reader["PRICEDAY"]);

                    name = Convert.ToString(reader["NAME"]);

                    loaned = Convert.ToBoolean(reader["LoanStatus"]);
                    returndate = Convert.ToDateTime(reader["DUEDATE"]);

                    temp.Add(new Item(name, loaned,priceperday,returndate));
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
        


    }
}
