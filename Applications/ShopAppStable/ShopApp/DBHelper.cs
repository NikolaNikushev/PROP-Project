using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopApp
{
    class DBHelper
    {
        public MySqlConnection connection;

        //----------------------------CONSTRUCTOR
        public DBHelper()
        {
            // using the shared dll to get the data
            connection = DBConnectionDll.Connection.connection;
        }

        //----------------------------GENERAL
        /// <summary>
        /// Retrieves all the products from a general stock
        /// </summary>
        /// <returns></returns>
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

                    temp.Add(new Product(id, name, price, quantity));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        /// <summary>
        /// Retrieves the products in stock of a certain shop
        /// Uses a view storeprodinfo to find the data easier
        /// </summary>
        /// <param name="ShopName"></param>
        /// <returns></returns>
        public List<Product> GetAllProducts(string ShopName)
        {
            String sql = "SELECT * " +
                "FROM storeprodinfo " +
                "WHERE storename = " + "'" + ShopName + "'" +
                "ORDER BY prodname;";
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
                    name = Convert.ToString(reader["prodname"]);
                    price = Convert.ToDouble(reader["price"]);
                    quantity = Convert.ToInt32(reader["quantity"]);

                    temp.Add(new Product(id, name, price, quantity));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        /// <summary>
        /// retireves quantity of a certain product by its id in a 
        /// shop with a specified ID
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetQuantity(int StoreId, int ProductId)
        {
            int quantity = -1;

            String sql = "SELECT INSTOREQUANTITY FROM productstorages WHERE" +
                " product_id = " + "\"" + ProductId + "\"" +
                "AND store_id = " + "\"" + StoreId + "\"";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    quantity = Convert.ToInt32(reader["INSTOREQUANTITY"]);
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

        /// <summary>
        /// retireves quantity of a certain product by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Loads all the store names from the database
        /// </summary>
        /// <returns></returns>
        public List<String> RetrieveStoreNames()
        {
            String sql = "SELECT STORENAME FROM STORES";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<String> temp;
            temp = new List<String>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                // data to build a new product upon 

                while (reader.Read())
                {
                    temp.Add(reader["STORENAME"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return temp;

        }

        /// <summary>
        /// Checks if tha access code is correct and returns TRUE if the connection was successful
        /// </summary>
        /// <param name="name"></param>
        /// <param name="acccode"></param>
        /// <returns></returns>
        public Boolean AuthorizeShop(string name, string acccode)
        {
            String sql = "SELECT * FROM STORES " +
                "WHERE STORENAME = " + "'" + name + "'" +
                "WHERE ACCESSCODE = " + "'" + acccode + "';";
            MySqlCommand command = new MySqlCommand(sql, connection);

            Boolean funcRes = false;

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                // data to build a new product upon 
                // only one exists with a combination like this
                if (reader.FieldCount == 1)
                {
                    funcRes = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return funcRes;
        }

        /// <summary>
        /// Gets an ID of a store by its name
        /// select STORE_ID FROM stores where STORENAME ="{name}"
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public int GetStoreId(string Name)
        {
            int id = -1;
            //select STORE_ID FROM stores where STORENAME ="MOES"
            String sql = "SELECT STORE_ID FROM STORES WHERE STORENAME = " + "\"" + Name + "\";";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["STORE_ID"]);
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
            return id;
        }

        //-------------------------------PURCHASE RELATED

        /// <summary>
        /// Records a purchase for that chosen shop of yours (has to be pass as thatShop)
        /// for the buyer with ID buyerId and also updates: 
        /// his balance - buyerBalance
        /// stock quantity
        /// and inserts data into storepayments table and populates the saleline
        /// </summary>
        /// <param name="buyerId"></param>
        /// <param name="buyerBalance"></param>
        /// <param name="thatShop"></param>
        public void RecordPurchase(int buyerId, ref double buyerBalance, Shop thatShop)
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

            // so not to go foreach every time we need it
            double tprice = thatShop.TotalPrice;
            buyerBalance -= tprice;
            try
            {
                //UPDATE `visitors` SET `BALANCE` = '45555000' WHERE `visitors`.`USER_ID` = 1124;
                command.CommandText = "UPDATE visitors SET BALANCE = " +
                   (buyerBalance) + " WHERE visitors.USER_ID = " + // new balance
                    buyerId + ";"; // buyer id
                int numberOfRowsAffected = command.ExecuteNonQuery();
                if(numberOfRowsAffected==0)
                {
                    throw new Exception("This visitor does not exist");
                }
                //INSERT INTO `storepayment` (`PAYMENT_ID`, `USER_ID`, `STORE_ID`, `TOTALPRICE`, `PURCHASETIME`) VALUES (NULL, '1124', '3', '120', '2016-06-23 06:20:28');
                command.CommandText =
                    "INSERT INTO storepayment (USER_ID,STORE_ID,TOTALPRICE,PURCHASETIME) VALUES " +
                    "('" + buyerId + "', '" + // user id
                    thatShop.Id + "','" +  // store ID
                    thatShop.TotalPrice + "'," + // total price
                    "NOW()" + ");"; // current time
                command.ExecuteNonQuery();

                //Payment ID
                command.CommandText = "SELECT LAST_INSERT_ID() AS LID";
                MySqlDataReader reader = command.ExecuteReader();
                int paymentId = -1;
                while (reader.Read())
                {
                    paymentId = Convert.ToInt32(reader["LID"]);
                }
                if(paymentId==-1)
                {
                    throw new Exception("Last ID was not retrieved");
                }
                reader.Close();
                //Inserting saleline items and updating the qunatity in stock
                foreach (Product p in thatShop.Basket)
                {
                    // Inserting into saleline
                    // INSERT INTO `salelines` (`PRODUCT_ID`, `QUANTITY`, `PAYMENT_ID`) VALUES ('3', '45', '1');
                    command.CommandText = "INSERT INTO salelines (PRODUCT_ID, QUANTITY, PAYMENT_ID) VALUES ('" +
                        p.Id + "', '" +
                        p.Quantity + "', '" +
                        paymentId + "');";
                    command.ExecuteNonQuery();

                    // Updating the stock
                    // UPDATE `productstorages` SET `INSTOREQUANTITY` = '34' WHERE `productstorages`.`PRODUCT_ID` = 1 AND `productstorages`.`STORE_ID` = 1;
                    command.CommandText = "UPDATE productstorages " +
                        "SET INSTOREQUANTITY = " + "'" + (thatShop.GetStockQunatityInStoreByProductID(p.Id) - p.Quantity) + "' " + // new quantity = oldQ - inbasketQ
                        "WHERE PRODUCT_ID = " + p.Id +
                        " AND STORE_ID = " + thatShop.Id + ";";
                    command.ExecuteNonQuery();
                }

                // Attempt to commit the transaction.
                transaction.Commit();
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
        }

        //public void UpdateQuantity(string name, int newQantity)
        //{
        //    String sql = "UPDATE foodproducts1 SET quantity = " + newQantity.ToString() + " WHERE name = " + "\"" + name + "\"";
        //    MySqlCommand command = new MySqlCommand(sql, connection);
        //    try
        //    {
        //        connection.Open();
        //        MySqlDataReader reader = command.ExecuteReader();
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

        public double getBalance(string bracelet_id, out int buyerId)
        {
            double balance = -1;
            buyerId = 0;
            String sql = "SELECT BALANCE, USER_ID FROM visitors WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    balance = Convert.ToDouble(reader["BALANCE"]);
                    buyerId = Convert.ToInt32(reader["USER_ID"]);
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
            double left = (newBalance - Math.Floor(newBalance)) * 10;
            newBalance = Math.Floor(newBalance);
            String sql = "UPDATE visitors SET BALANCE = " + newBalance.ToString() + "." + left.ToString() + " WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
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
