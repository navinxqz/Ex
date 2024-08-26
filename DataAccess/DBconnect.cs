using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;
using System;

namespace AdminSystem.DataAccess
{
    public class DBconnect
    {
        /*static MySqlConnection connection = null;
        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection("Server=127.0.0.1;Database=adminsystem;Uid=root;");
            }return connection;
        }
        static QueryFactory db = null;
        public static QueryFactory Db() {
            if(db == null)
            {
                var compiler = new MySqlCompiler();
                db = new QueryFactory(GetConnection(),compiler);
            }
            return db;
        } */

        private static string connection = "Server=127.0.0.1;Database=adminsystem;Uid=root;";
        public static string Connect { get { return connection; } }
        public MySqlConnection con = new MySqlConnection(Connect);

        public MySqlDataReader MySqlSelect(string query)
        {
            MySqlConnection con = new MySqlConnection(Connect);
            MySqlCommand s = new MySqlCommand(query, con);
            con.Open();
            Console.WriteLine(con);
            MySqlDataReader read = s.ExecuteReader();
            Console.WriteLine(read.ToString());
            return read;
        }

        public int MySqlExacute(string query)
        {
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();

            MySqlCommand cmd = new MySqlCommand(query, con);
            object result = cmd.ExecuteScalar();
            return result !=null ? Convert.ToInt32(result) : 0;
        }

        public int MySqlNonQ(string query)
        {
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}
