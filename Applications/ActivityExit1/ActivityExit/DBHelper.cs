using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace ActivityExit
{
    public class DBHelper
    {
        private MySqlConnection connection;
        MySqlDataReader reader;
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
        private void increasePlaces()
        {
            connection.Open();
            reader = IncreacePlacesCommand().ExecuteReader();
        }

        private MySqlCommand IncreacePlacesCommand(string activityName)
        {
            string increasePlacesQuery = "UPDATE activities " +
                                         "SET OPENPLACESTAKEN = OPENPLACESTAKEN - 1 " +
                                         "WHERE ACTIVITYNAME = " + "\"" + activityName + "\";";
            MySqlCommand increasePlacesCommand = new MySqlCommand(increasePlacesQuery, connection);
            return increasePlacesCommand;

        }
    }
}
