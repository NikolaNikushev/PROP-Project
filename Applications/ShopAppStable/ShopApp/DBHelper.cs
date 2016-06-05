using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ShopApp
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

        public List<Product> GetAllProducts()
        {
            String sql = "SELECT * FROM foodproducts ORDER BY name";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Product> temp;
            temp = new List<Product>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                // data to build a new product upon 
                int id;
                int quantity;
                string name;
                double price;

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["product_id"]);
                    name = Convert.ToString(reader["name"]);
                    price = Convert.ToDouble(reader["price"]);
                    quantity = Convert.ToInt32(reader["stock"]);

                    temp.Add(new Product(id,name, price,quantity));
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


        public int GetQuantity(string name)
        {
            int quantity = -1;

            String sql = "SELECT STOCK FROM foodproducts WHERE name = " + "\"" + name + "\"";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    quantity = Convert.ToInt32(reader["STOCK"]);
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
            return quantity;
        }


        public void UpdateQuantity(string name, int newQantity)
        {
            String sql = "UPDATE foodproducts1 SET quantity = "+newQantity.ToString()+" WHERE name = " + "\"" + name+ "\"";
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
