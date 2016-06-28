using System;
using MySql.Data.MySqlClient;

namespace DBConnectionDll
{
    static public class Connection
    {
        public const String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi339282;" +
                                    "user id=dbi339282;" +
                                    "password=bccMxqtHck;" +
                                    "connect timeout=30;" +
                                    "convert zero datetime=True";

        public static MySqlConnection connection = new MySqlConnection(connectionInfo);
    }
}
