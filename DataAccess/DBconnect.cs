using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSystem.DataAccess
{
    public static class DBconnect
    {
        static MySqlConnection connection = null;
        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection("");
            }return connection;
        }
    }
}
