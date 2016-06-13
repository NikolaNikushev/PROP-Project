using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Modules
{
    public enum StorageTypes
    {
        GLOBAL,
        LOCAL
    }
    

    static public class WareHouseCntrl
    {
       
        /// <summary>
        /// Populates the data in the specified datagridview. 
        /// Takes a dgv to be managed, type of storage and optionally a storeName to populate it with according data
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="stype"></param>
        /// <param name="OptioalStoreName"></param>
        static public void PopulateGridData(DataGridView dgv, StorageTypes stype, String OptioalStoreName = "" )
        {
            dgv.Rows.Clear();
            
            List<Product> lp = new List<Product>();
            if (stype == StorageTypes.GLOBAL)
            {
                lp = Warehouse.GetAllProducts();
            }
            else
            {
                lp = Warehouse.GetAllProducts(OptioalStoreName);
            }
            if(dgv.Columns.Count<4)
            {
                dgv.Columns.Add("colID", "ID");
                dgv.Columns.Add("colName", "Name");
                dgv.Columns.Add("colPrice", "Price");
                dgv.Columns.Add("colQuantity", "Qunatity");
            }
            dgv.Width = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.None);
            foreach(ProductToSell p in lp)
            {
                dgv.Rows.Add(p.Id, p.Name, p.Price, p.Quantity);
            }
            
        }

        /// <summary>
        /// Populates the data in the specified sombobox
        /// </summary>
        /// <param name="cmbx"></param>
        static public void PopulateComboBox(ComboBox cmbx)
        {
            if(cmbx.Items.Count<=2)
            {
                cmbx.Items.AddRange(Warehouse.RetrieveStoreNames().ToArray());
            }
        }

    }


    static class Warehouse
    {
        /// <summary>
        /// Retrieves all data about the products in the warehouse
        /// </summary>
        /// <returns></returns>
        static public List<Product> GetAllProducts()
        {
            String sql = "SELECT * FROM foodproducts ORDER BY name";
            MySqlCommand command = new MySqlCommand(sql, Connection.connection);

            List<Product> temp;
            temp = new List<Product>();

            try
            {
                Connection.connection.Open();
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

                    temp.Add(new ProductToSell(id, name, price, quantity));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Connection.connection.Close();
            }
            return temp;
        }

        /// <summary>
        /// Gets the data about all the products in storage of a shop specified by its name at a current moment
        /// </summary>
        /// <param name="ShopName"></param>
        /// <returns></returns>
        static public List<Product> GetAllProducts(string ShopName)
        {
            String sql = "SELECT * " +
                "FROM storeprodinfo " +
                "WHERE storename = " + "'" + ShopName + "'" +
                "ORDER BY prodname;";
            MySqlCommand command = new MySqlCommand(sql, Connection.connection);

            List<Product> temp;
            temp = new List<Product>();

            try
            {
                Connection.connection.Open();
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

                    temp.Add(new ProductToSell(id, name, price, quantity));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Connection.connection.Close();
            }
            return temp;
        }


        /// <summary>
        /// Loads all the store names from the database
        /// </summary>
        /// <returns></returns>
        static public List<String> RetrieveStoreNames()
        {
            String sql = "SELECT STORENAME FROM STORES";
            MySqlCommand command = new MySqlCommand(sql, Connection.connection);

            List<String> temp;
            temp = new List<String>();

            try
            {
                Connection.connection.Open();
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
                Connection.connection.Close();
            }
            return temp;

        }

        static public List<Product> GetHistoryProducts(string ShopName)
        {
            String sql = "SELECT * " +
                "FROM storeprodinfo " +
                "WHERE storename = " + "'" + ShopName + "'" +
                "ORDER BY prodname;";
            MySqlCommand command = new MySqlCommand(sql, Connection.connection);

            List<Product> temp;
            temp = new List<Product>();

            try
            {
                Connection.connection.Open();
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

                    temp.Add(new ProductToSell(id, name, price, quantity));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Connection.connection.Close();
            }
            return temp;
        }

    }

}
