using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mobilitec_Services
{
    class Connect
    {
        private static string connString = "server=localhost;port=3306;database=dbmobiliteservice;uid=root;pwd=";
        private static MySqlConnection conn = null;
        public static MySqlConnection obterConexao()    
        {
            conn = new MySqlConnection(connString);
            conn.Open();
            return conn;
            
        }
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
