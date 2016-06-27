using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;




namespace Modules
{
    public enum StorageTypes
    {
        GLOBAL,
        LOCAL
    }


    public class WareHouseCntrl
    {
        public WareHouseCntrl(ComboBox cmbx, ComboBox cmbxHstry = null, ListBox lb = null, Label[] lbls = null)
        {
            try
            {
                WareHouseCntrl.PopulateComboBox(cmbx);
                WareHouseCntrl.PopulateComboBox(cmbxHstry);
                WareHouseCntrl.UpdateOverview(lb, lbls[0], lbls[1], lbls[2]);
            }
            catch
            {
                Console.WriteLine("Couldn't update the data");
                throw new Exception("Couldn't update the data");
            }


        }
        /// <summary>
        /// Populates the data in the specified datagridview. 
        /// Takes a dgv to be managed, type of storage and optionally a storeName to populate it with according data
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="stype"></param>
        /// <param name="OptioalStoreName"></param>
        static public void PopulateGridData(DataGridView dgv, StorageTypes stype, String OptioalStoreName = "")
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
            if (dgv.Columns.Count < 4)
            {
                dgv.Columns.Add("colID", "ID");
                dgv.Columns.Add("colName", "Name");
                dgv.Columns.Add("colPrice", "Price");
                dgv.Columns.Add("colQuantity", "Qunatity");
            }
            dgv.Width = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.None);
            foreach (ProductToSell p in lp)
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
            if (cmbx.Items.Count <= 2)
            {
                cmbx.Items.AddRange(Warehouse.RetrieveStoreNames().ToArray());
            }
        }
        /// <summary>
        /// Populates the coolection of a combobox to select a product
        /// </summary>
        /// <param name="cmbx"></param>
        /// <param name="storeName"></param>
        static public void PopulateProdOfStoreComboBox(ComboBox cmbx, string storeName)
        {
            if (cmbx.Items.Count < 1)
            {
                cmbx.Items.AddRange(Warehouse.RetrieveInStoreProds(storeName).ToArray());
            }
        }
        /// <summary>
        /// updates overview tab and populates it with all the data to the accroding controls
        /// </summary>
        /// <param name="lbTopPopProd"></param>
        /// <param name="lblTotPurchVal"></param>
        /// <param name="lblGrosAmPaidVal"></param>
        /// <param name="lblHotHourVal"></param>
        static public void UpdateOverview(ListBox lbTopPopProd, Label lblTotPurchVal, Label lblGrosAmPaidVal, Label lblHotHourVal)
        {
            // 0 - number of payments
            // 1 - gross amount
            // 2 - busiest hour
            lbTopPopProd.Items.Clear();
            string[] labels = Warehouse.GetNumberAndGrossAmountOfPurchases();
            lblTotPurchVal.Text = labels[0];
            lblGrosAmPaidVal.Text = labels[1] + " " + System.Globalization.CultureInfo.GetCultureInfo("nl-NL").NumberFormat.CurrencySymbol;
            lblHotHourVal.Text = labels[2];
            foreach (ProductToSell p in Warehouse.GetTopPopularProducts())
            {
                lbTopPopProd.Items.Add(p.Name + " was sold: " + p.Quantity + " times");
            }

        }

        /// <summary>
        /// Retrieves a list of archived product states
        /// </summary>
        /// <param name="ShopName"></param>
        /// <param name="ProductName"></param>
        static public void GetHistoricalData(Chart chartToMan, string ShopName, string ProductName)
        {
            try
            {
                List<ProductArchive> pa = Warehouse.GetHistoryProducts(ShopName, ProductName);
                
                    chartToMan.Series[0].Points.Clear();
                chartToMan.Series[1].Points.Clear();

                if (pa.Count == 0)
                {
                    chartToMan.Series[0].Points.Add(0, 0);
                    chartToMan.Series[0].Points.Add(0, 1);
                }
                
                foreach (ProductArchive pia in pa)
                {
                    chartToMan.Series[0].Points.AddXY((pia.SliceTime.Date).ToString(), pia.QuantityArch); // number in stock
                    chartToMan.Series[1].Points.AddXY((pia.SliceTime.Date).ToString(), pia.NumSoldArch); // number sold
                }
                //this.chartProductHistory.Series[0].Points.AddXY(1, 2);

            }
            catch
            {
                Console.WriteLine("Damn! something went wrong");
                throw new Exception("Damn! something went wrong");
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
            MySqlCommand command = new MySqlCommand(sql, DBConnectionDll.Connection.connection);

            List<Product> temp;
            temp = new List<Product>();

            try
            {
                DBConnectionDll.Connection.connection.Open();
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
                DBConnectionDll.Connection.connection.Close();
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
            MySqlCommand command = new MySqlCommand(sql, DBConnectionDll.Connection.connection);

            List<Product> temp;
            temp = new List<Product>();

            try
            {
                DBConnectionDll.Connection.connection.Open();
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
                DBConnectionDll.Connection.connection.Close();
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
            MySqlCommand command = new MySqlCommand(sql, DBConnectionDll.Connection.connection);

            List<String> temp;
            temp = new List<String>();

            try
            {
                DBConnectionDll.Connection.connection.Open();
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
                DBConnectionDll.Connection.connection.Close();
            }
            return temp;

        }




        /// <summary>
        /// Retrieves the historical data about a certain product in a shop
        /// Last entry depicts the current situation
        /// </summary>
        /// <param name="ShopName"></param>
        /// <returns></returns>
        static public List<ProductArchive> GetHistoryProducts(string ShopName, string ProductName)
        {
            DBConnectionDll.Connection.connection.Open();

            MySqlCommand command = DBConnectionDll.Connection.connection.CreateCommand();

            //// Must assign both transaction object and connection
            //// to Command object for a pending local transaction
            command.Connection = DBConnectionDll.Connection.connection;

            List<ProductArchive> temp;
            temp = new List<ProductArchive>();

            try
            {
                /// select SLICETIME, PRODUCT_ID, QUANTITY, NUMSALES from storeperfarchive 
                /// WHERE PRODNAME = 'Yellow Cheese' AND STORE_ID = (SELECT STORE_ID FROM stores WHERE UPPER(STORENAME) = 'MOES') 
                /// UNION select SLICETIME, PRODUCT_ID, QUANTITY, NUMSALES from current_quan_sales 
                /// WHERE PRODNAME = 'Yellow Cheese' AND STORE_ID = (SELECT STORE_ID FROM stores WHERE UPPER(STORENAME) = 'MOES')

                string selectClause = " SELECT PRODUCT_ID, SLICETIME, QUANTITY, NUMSALES ";
                string whereClause = " WHERE PRODNAME = '" + ProductName + "' " +
                    "AND STORE_ID = (SELECT STORE_ID FROM stores " +
                    "WHERE STORENAME = '" + ShopName + "') ";

                command.CommandText = selectClause +
                    "FROM storeperfarchive " +
                    whereClause +
                    "UNION "+ selectClause +
                    " from current_quan_sales" +
                    whereClause + ";";




                MySqlDataReader reader = command.ExecuteReader();
                // data to build a new product upon 
                string name = ProductName;
                DateTime SliceTime;
                int id = -1;
                int QuantityArch = 0;
                int NumSoldArch = 0;
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["PRODUCT_ID"]);
                    SliceTime = Convert.ToDateTime(reader["SLICETIME"]);
                    QuantityArch = Convert.ToInt32(reader["QUANTITY"]);
                    NumSoldArch = Convert.ToInt32(reader["NUMSALES"]);

                    //price = Convert.ToDouble(reader["price"]);
                    //quantity = Convert.ToInt32(reader["quantity"]);

                    temp.Add(new ProductArchive(id, name, SliceTime, NumSoldArch, QuantityArch));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DBConnectionDll.Connection.connection.Close();
            }
            return temp;
        }



        /// <summary>
        /// Retrieves a list of top 7 popular products gets their number of sales and also general info
        /// </summary>
        /// <returns></returns>
        static public List<Product> GetTopPopularProducts()
        {
            String sql = "SELECT SUM(sl.QUANTITY) as SOLDITEMS, sl.PRODUCT_ID as ID, fp.NAME as prodname, fp.PRICE as price " +
                "FROM salelines sl " +
                "join foodproducts fp " +
                "on sl.PRODUCT_ID = fp.PRODUCT_ID " +
                "GROUP BY sl.PRODUCT_ID " +
                "ORDER BY SUM(QUANTITY)DESC " +
                "LIMIT 7;";
            MySqlCommand command = new MySqlCommand(sql, DBConnectionDll.Connection.connection);

            List<Product> temp;
            temp = new List<Product>();

            try
            {
                DBConnectionDll.Connection.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                // data to build a new product upon 
                int id;
                int quantity;
                string name;
                double price;

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["prodname"]);
                    price = Convert.ToDouble(reader["price"]);
                    quantity = Convert.ToInt32(reader["SOLDITEMS"]);

                    temp.Add(new ProductToSell(id, name, price, quantity));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DBConnectionDll.Connection.connection.Close();
            }
            return temp;
        }

        /// <summary>
        /// Gets data about the payments returns an array of strings representing: 
        /// 0 -  number of payments;
        /// 1 - gross amount of money;
        /// 2 - busiest time
        /// </summary>
        /// <returns></returns>
        static public string[] GetNumberAndGrossAmountOfPurchases()
        {
            String sql = "SELECT COUNT(PAYMENT_ID) as NUMPMNTS," +
                " SUM(TOTALPRICE) as GROSS, " +
                    "(SELECT PURCHASETIME from storepayment " +
                    "GROUP BY PURCHASETIME " +
                    "ORDER BY COUNT(PAYMENT_ID) DESC LIMIT 1) as " +
                "HOTHOUR " +
                "FROM storepayment;";
            MySqlCommand command = new MySqlCommand(sql, DBConnectionDll.Connection.connection);

            string[] querRes = new string[3];

            try
            {
                DBConnectionDll.Connection.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                // data to build a new product upon 

                while (reader.Read())
                {
                    // number of payments
                    querRes[0] = (reader["NUMPMNTS"]).ToString();
                    // gross amount of money
                    querRes[1] = (reader["GROSS"]).ToString();
                    // busiest time
                    string hour = (reader["HOTHOUR"]).ToString();
                    hour = hour.Substring(hour.IndexOf(' '));
                    querRes[2] = hour;//(reader["HOTHOUR"]).ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DBConnectionDll.Connection.connection.Close();
            }

            return querRes;
        }




        /// <summary>
        /// Gets all the products available in the store
        /// query: SELECT PRODNAME FROM storeprodinfo
        /// </summary>
        /// <param name="StoreName"></param>
        /// <returns></returns>
        static public List<String> RetrieveInStoreProds(String StoreName)
        {
            String sql = "SELECT PRODNAME FROM storeprodinfo WHERE STORENAME = '" + StoreName + "';";
            MySqlCommand command = new MySqlCommand(sql, DBConnectionDll.Connection.connection);

            List<String> temp;
            temp = new List<String>();

            try
            {
                DBConnectionDll.Connection.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                // data to build a new product upon 

                while (reader.Read())
                {
                    temp.Add(reader["PRODNAME"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                DBConnectionDll.Connection.connection.Close();
            }
            return temp;

        }

    }

}
