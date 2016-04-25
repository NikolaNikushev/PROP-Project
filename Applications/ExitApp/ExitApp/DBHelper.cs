using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ExitApp
{
    public class DBHelper
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
        //public int CheckIfPaid(string bracelet_id)
        //{
        //    String sql = "SELECT PAID FROM visitors WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
        //    MySqlCommand command = new MySqlCommand(sql, connection);

        //    int paid = -1;
        //    try
        //    {
        //        connection.Open();
        //        MySqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            paid = Convert.ToInt32(reader["PAID"]);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return paid;
        //}

        //public List<Visitor> GetAllVisitors()
        //{
        //    String sql = "SELECT * FROM visitors";
        //    MySqlCommand command = new MySqlCommand(sql, connection);

        //    List<Visitor> temp;
        //    temp = new List<Visitor>();

        //    try
        //    {
        //        connection.Open();
        //        MySqlDataReader reader = command.ExecuteReader();

        //        int u_id;
        //        string pass;
        //        string mail;
        //        string fnm;
        //        string lnm;
        //        DateTime db;
        //        double blnc;
        //        bool pay;
        //        string b_id;
        //        int c_id;
        //        int st;

        //        while (reader.Read())
        //        {
        //            if (reader["user_id"] == DBNull.Value) { u_id = 0; }
        //            else { u_id = Convert.ToInt32(reader["user_id"]); }

        //            pass = Convert.ToString(reader["password"]);

        //            mail = Convert.ToString(reader["email"]);

        //            fnm = Convert.ToString(reader["fname"]);

        //            lnm = Convert.ToString(reader["lname"]);

        //            db = Convert.ToDateTime(reader["dob"]);

        //            blnc = Convert.ToDouble(reader["balance"]);

        //            pay = Convert.ToBoolean(reader["paid"]);

        //            if (reader["bracelet_id"] == DBNull.Value) { b_id = null; }
        //            else { b_id = Convert.ToString(reader["bracelet_id"]); }

        //            if (reader["camping_id"] == DBNull.Value) { c_id = 0; }
        //            else { c_id = Convert.ToInt32(reader["camping_id"]); }

        //            st = Convert.ToInt32(reader["camping_id"]);

        //            temp.Add(new Visitor(u_id, pass, mail, fnm, lnm, db, blnc, pay, b_id, c_id, st));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return temp;
        //}

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

        public void UpdateStatus(string bracelet_id)
        {
            String sql;
            MySqlCommand command;

            if (GetStatus(bracelet_id) == 1)
            {
                sql = "UPDATE visitors SET STATUS=0 WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
                command = new MySqlCommand(sql, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    AutoClosingMessageBox.Show(ex.ToString(),"caption",1000);
                }
                finally
                {
                    connection.Close();
                }
                AutoClosingMessageBox.Show("Have a nice day", "bastard", 1000);
            }
            else
            if (GetStatus(bracelet_id) == 0)
            {
                //sql = "UPDATE visitors SET STATUS=1 WHERE BRACELET_ID = " + "\"" + bracelet_id + "\"";
                //command = new MySqlCommand(sql, connection);

                //try
                //{
                //    connection.Open();
                //    MySqlDataReader reader = command.ExecuteReader();
                //}
                //catch (Exception ex)
                //{
                //    AutoClosingMessageBox.Show(ex.ToString(), "caption", 1000);
                //}
                //finally
                //{
                //    connection.Close();
                //}
                AutoClosingMessageBox.Show("You slimy bastard, you fooled us this time", "bastard", 1000);
            }
            else
            {
                AutoClosingMessageBox.Show("Not a valid bracelet", "Caption", 1000);
            }
        }



    }
}
