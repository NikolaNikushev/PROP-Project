using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modules
{
    static class Connection
    {
        private const String connectionInfo = "server=localhost;" +
                                    "database=propdbtest;" +
                                    "user id=root;" +
                                    "password=;" +
                                    "connect timeout=30;" +
                                    "convert zero datetime=True";

        public static MySqlConnection connection = new MySqlConnection(connectionInfo);
    }    
}
