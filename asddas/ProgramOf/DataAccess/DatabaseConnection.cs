using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProgramOf.DataAccess
{
    class DatabaseConnection
    {
        public static MySqlConnection GetDbConnection(string server, string database, string userid, string password)
        {
            String conString = "Server=" + server + 
                               ";Database=" + database + 
                               ";UserId=" + userid + 
                               ";Password=" + password +
                               ";pooling=false;Connection Timeout=10000";

            MySqlConnection con = new MySqlConnection(conString);
            return con;
        }
    }
}
