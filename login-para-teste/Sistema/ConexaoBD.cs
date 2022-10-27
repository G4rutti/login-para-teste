using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConexaoBD
{

    public static MySqlConnectionStringBuilder Connection
    {
        get
        {
            return new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                UserID = "root",
                Password = "",
                Database = "db_tela_login_1"
            };
        }
        private set
        {

        }
    }
}