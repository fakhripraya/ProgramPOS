using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProgramOf.DataAccess
{
    class DBUtils
    {
        public static MySqlConnection GetDbConnection()
        {
            string server = "127.0.0.1";
            string database = "tenantbsd";
            string userid = "root";
            string password = "123456";

            return DatabaseConnection.GetDbConnection(server, database, userid, password);
        }
    }
}
