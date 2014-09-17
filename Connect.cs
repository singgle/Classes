using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace singgle.Classes
{
    class Connect
    {
        private MySqlConnection Conn;

        public void abrirConexao()
        {
            Conn = new MySqlConnection("server=69.64.33.121;user id=mnettec1_sing;password"+
                        "=poucasombra10;persistsecurityinfo=True;database=mnettec1_singgle");
            Conn.Open();
        }

        public void fecharConexao()
        {
            Conn.Close();
        }
    }
}
