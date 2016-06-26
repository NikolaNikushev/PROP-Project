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
    public class VisitorsCntrl
    {
        /// <summary>
        /// Executed at the creation of the controller - in this case at the opening of a tab visitors
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="lblBracNumVal"></param>
        public VisitorsCntrl(DataGridView dgv, Label lblBracNumVal, Label[] lbls = null)
        {
            VisitorsCntrl.PopulateBraceletSection(dgv, lblBracNumVal);
        }

        /// <summary>
        /// Populates the bracelet section of the visitors tab 
        /// Fills the data in the gridview and also displays the number of bracelets in total
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="lblBracNumVal"></param>
        static public void PopulateBraceletSection(DataGridView dgv, Label lblBracNumVal)
        {
            dgv.Rows.Clear();

            List<Bracelet> lb = new List<Bracelet>();
            int nmbr;
            lb = VisitorsDb.GetAllBracelets(out nmbr);
            lblBracNumVal.Text = nmbr.ToString();

            if (dgv.Columns.Count < 2)
            {
                dgv.Columns.Add("colID", "ID");
                dgv.Columns.Add("colStatus", "Status");
            }
            dgv.Width = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.None);
            foreach (Bracelet b in lb)
            {
                dgv.Rows.Add(b.Id, b.Status);
            }
        }


        static public void PopulateVisitorGroupData()
        {

        }

    }

    static public class VisitorsDb
    {
        /// <summary>
        /// Gets all bracelets from the database and also counts their number
        /// the number is returned via the out parameter nmbr 
        /// </summary>
        /// <param name="nmbr"></param>
        /// <returns></returns>
        static public List<Bracelet> GetAllBracelets(out int nmbr)
        {
            String sql = "SELECT * FROM rfids";
            MySqlCommand command = new MySqlCommand(sql, Connection.connection);
            nmbr = 0;
            List<Bracelet> temp;
            temp = new List<Bracelet>();

            try
            {
                Connection.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                // data to build a new product upon 
                string id;
                BracStatusType status = BracStatusType.NOT_VALID;

                while (reader.Read())
                {
                    id = Convert.ToString(reader["bracelet_id"]);
                    nmbr++;
                    try
                    {
                        // converts a string retrieved from db to the enum type
                        status = (BracStatusType)Enum.Parse(typeof(BracStatusType), reader["status"].ToString());
                    }
                    catch
                    {
                        Console.WriteLine("damn");
                    }
                    
                    temp.Add(new Bracelet(id, status));
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
        /// Gets the number of total registered users (out as nmbrTotal), of expected visitors - those who'd paid (out as nmbrExp), 
        /// of present visitors - those who are right now at the festival (out as nmbrPres)
        /// </summary>
        /// <param name="nmbrTotal"></param>
        /// <param name="nmbrExp"></param>
        /// <param name="nmbrPres"></param>
        static public void GetNmbrOfVistrPerStatus(out int nmbrTotal, out int nmbrExp, out int nmbrPres)
        {
            nmbrTotal = 0;
            nmbrExp = 0;
            nmbrPres = 0;
            /// SELECT count(*) as TotalVis, 
            /// (Select count(*) from visitors where PAID = 1) 
            /// as ExpVis, 
            /// (Select count(*) from visitors where PAID = 1 AND STATUS = 1) 
            /// as PresVis 
            /// From visitors
            /// 
            String sql = "SELECT count(*) as TotalVis"+
                ", (Select count(*) from visitors where PAID = 1) as ExpVis"+
                ", (Select count(*) from visitors where PAID = 1 AND STATUS = 1) as PresVis"+
                " From visitors";
            MySqlCommand command = new MySqlCommand(sql, Connection.connection);
            List<Bracelet> temp;
            temp = new List<Bracelet>();

            try
            {
                Connection.connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int.TryParse(reader["TotalVis"].ToString(), out nmbrTotal);
                    int.TryParse(reader["ExpVis"].ToString(), out nmbrExp);
                    int.TryParse(reader["PresVis"].ToString(), out nmbrPres);
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
        }
    }

    /// <summary>
    /// Stores the data about an RFID 
    /// complies with the database template
    /// </summary>
    public class Bracelet
    {
        public string Id
        {
            get;
            private set;
        }

        public BracStatusType Status
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates an instance of a bracelet with the set parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        public Bracelet(string id, BracStatusType status)
        {
            this.Id = id;
            this.Status = status;
        }
    }

    public enum BracStatusType
    {
        DEACTIVATED,
        ACTIVE,
        STAND_BY,
        NOT_VALID
    }
}
