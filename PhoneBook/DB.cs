using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PhoneBook
{
    class DB
    {
        MySqlConnection conn = new MySqlConnection("user = root; password = root; SSL Mode = None; server = 127.0.0.1; port = 3306; database = phonenumbers");
        public MySqlConnection getConnection()
        {
            return conn;
        }
        public void connectionOpen()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        public void connectionClose()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
