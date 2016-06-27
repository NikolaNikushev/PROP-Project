using System;
using MySql.Data.MySqlClient;

namespace DBConnectionDll
{
    static public class Connection
    {
        public const String connectionInfo = "server=localhost;" +
                                    "database=propdbtest;" +
                                    "user id=root;" +
                                    "password=;" +
                                    "connect timeout=30;" +
                                    "convert zero datetime=True";

        public static MySqlConnection connection = new MySqlConnection(connectionInfo);
    }
}
