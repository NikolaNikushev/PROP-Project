using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CampingEntryApp
{
    public class DBHelper
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


        public List<Visitor> GetAllVisitors()
        {
            String sql = "SELECT * FROM visitors";
            MySqlCommand command = new MySqlCommand(sql, connection);

            List<Visitor> temp;
            temp = new List<Visitor>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int u_id;
                string pass;
                string mail;
                string fnm;
                string lnm;
                DateTime db;
                double blnc;
                bool pay;
                string b_id;
                int c_id;
                int st;

                while (reader.Read())
                {
                    if (reader["user_id"] == DBNull.Value) { u_id = 0; }
                    else { u_id = Convert.ToInt32(reader["user_id"]); }

                    pass = Convert.ToString(reader["password"]);

                    mail = Convert.ToString(reader["email"]);

                    fnm = Convert.ToString(reader["fname"]);

                    lnm = Convert.ToString(reader["lname"]);

                    db = Convert.ToDateTime(reader["dob"]);

                    blnc = Convert.ToDouble(reader["balance"]);

                    pay = Convert.ToBoolean(reader["paid"]);

                    if (reader["bracelet_id"] == DBNull.Value) { b_id = null; }
                    else { b_id = Convert.ToString(reader["bracelet_id"]); }

                    if (reader["camping_id"] == DBNull.Value) { c_id = 0; }
                    else { c_id = Convert.ToInt32(reader["camping_id"]); }

                    st = Convert.ToInt32(reader["status"]);

                    temp.Add(new Visitor(u_id, pass, mail, fnm, lnm, db, blnc, pay, b_id, c_id, st));
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

        public int GetStatus(string bracelet_id)
        {
            int status = -1;

            String sql = "SELECT STATUS FROM visitors WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    status = Convert.ToInt32(reader["STATUS"]);
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
            return status;
        }

        public int GetCampingID(string bracelet_id)
        {
            int camping_id = -1;

            String sql = "SELECT CAMPING_ID FROM visitors WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["CAMPING_ID"] != DBNull.Value)
                    {
                        camping_id = Convert.ToInt32(reader["CAMPING_ID"]);
                    }
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
            return camping_id;
        }

        public int GetUserID(string bracelet_id)
        {
            int user_id = -1;

            String sql = "SELECT USER_ID FROM visitors WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user_id = Convert.ToInt32(reader["USER_ID"]);
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
            return user_id;
        }

        public DateTime GetArrivalDate(int camping_id)
        {
            DateTime arrivalDate = DateTime.MinValue;

            String sql = "SELECT ARRIVALDATE FROM tentleaders WHERE CAMPING_ID = " + camping_id;
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["ARRIVALDATE"] != DBNull.Value)
                    {
                        arrivalDate = Convert.ToDateTime(reader["ARRIVALDATE"]);
                    }
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
            return arrivalDate;
        }
        public void UpdateStatus(string bracelet_id)
        {
            String sql;
            MySqlCommand command;

            if (GetStatus(bracelet_id) == 1)
            {
                //sql = "UPDATE visitors SET STATUS=0 WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
                //command = new MySqlCommand(sql, connection);

                //try
                //{
                //    connection.Open();
                //    MySqlDataReader reader = command.ExecuteReader();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString());
                //}
                //finally
                //{
                //    connection.Close();
                //}
                AutoClosingMessageBox.Show("well dude you are already inside", "caption", 1000);
            }
            else
            if (GetStatus(bracelet_id) == 0)
            {
                sql = "UPDATE visitors SET STATUS=1 WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
                command = new MySqlCommand(sql, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    AutoClosingMessageBox.Show(ex.ToString(), "caption", 1000);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                AutoClosingMessageBox.Show("Not a valid bracelet", "Caption", 1000);
            }
        }

        public void UpdateLocation(string user_id)
        {
            DateTime theDate = DateTime.Now;
            string theDateString = theDate.ToString("yyyy-MM-dd H:mm:ss");

            String sql = "INSERT INTO location_history (USER_ID, CAMPING, TIME_ENTRANCE) VALUES ('" + user_id + "',1,'" + theDateString + "')";
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

        public double GetBalance(string bracelet_id)
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
        public int GetPeoplePerTent(int camping_id)
        {
            int people = 0;
            String sql = " SELECT COUNT(*) AS PEOPLE FROM visitors WHERE CAMPING_ID = " + camping_id;
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    people = Convert.ToInt32(reader["PEOPLE"]);
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
            return people;
        }
        public void TentPayment(string bracelet_id, double sum)
        {
            int user_id = GetUserID(bracelet_id);
            DateTime date = DateTime.Now;
            string dateString = date.ToString("yyyy-MM-dd H:mm:ss");
            double paysum = sum;
            int people = (int)sum / 15;
            string description = "Tent Reservation Payment. Group of " + people.ToString();

            String sql = "INSERT INTO serpayments (USER_ID, DATE,PAYSUM,DESCRIPTION) VALUES ('" + user_id + "','" + dateString + "'," + sum + ",'" + description + "')";
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

        public void PayForDay(string bracelet_id, int camping_id)
        {
            int people = GetPeoplePerTent(camping_id);
            double oldBalance = GetBalance(bracelet_id);
            double sum = 15 * people;
            double newBalance = oldBalance - sum;
            if (newBalance >= 0)
            {
                string sql = "UPDATE visitors SET BALANCE=" + newBalance.ToString() + " WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
                MySqlCommand command = new MySqlCommand(sql, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    AutoClosingMessageBox.Show(ex.ToString(), "caption", 1000);
                }
                finally
                {
                    connection.Close();
                }
                AddDay(camping_id);
                TentPayment(bracelet_id, sum);
                AutoClosingMessageBox.Show("Extra Day Added To " + camping_id.ToString(), "caption", 4000);
            }
            else { AutoClosingMessageBox.Show("NOT ENOUGH CASH BOYAH", "caption", 4000); }

        }
        public DateTime GetLeaveDate(int camping_id)
        {
            DateTime leaveDate = DateTime.MinValue;

            String sql = "SELECT LEAVEDATE FROM tentleaders WHERE CAMPING_ID = " + camping_id;
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["LEAVEDATE"] != DBNull.Value)
                    {
                        leaveDate = Convert.ToDateTime(reader["LEAVEDATE"]);
                    }
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
            return leaveDate;
        }
        public void AddDay(int camping_id)
        {
            DateTime oldLeaveDate = GetLeaveDate(camping_id);
            DateTime newDate = oldLeaveDate.AddDays(1);
            string newDateString = newDate.ToString("yyyy-MM-dd H:mm:ss");


            string sql = "UPDATE tentleaders SET LEAVEDATE = '" + newDateString + "' WHERE CAMPING_ID = " + camping_id;
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
        public int IsVisitorIn(int user_id)
        {
            DateTime maxEnter = DateTime.MinValue;
            DateTime maxExit = DateTime.MinValue;
            String sql = "SELECT MAX(TIME_ENTRANCE) AS MAX, MAX(TIME_EXIT) AS MIN FROM location_history WHERE CAMPING=1 AND USER_ID=" + user_id.ToString() + " GROUP BY USER_ID";
            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["MAX"] != DBNull.Value)
                    {
                        maxEnter = Convert.ToDateTime(reader["MAX"]);
                    }
                    if (reader["MIN"] != DBNull.Value)
                    {
                        maxExit = Convert.ToDateTime(reader["MIN"]);
                    }
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

            if (maxEnter > maxExit) { return 1; }
            else { return 0; }
        }


    }
}
