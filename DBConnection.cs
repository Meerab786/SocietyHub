using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DB_Final
{
    public class DBConnection
    {
        private static string conn = "Server = localhost;" + "Database = db_finals;" + "Uid = root;" + "Pwd = Mee.786.r@b;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(conn);
        }
    }
}
