using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prjEindwerk_LotsOfLili.Helper
{
    public class Database
    {
        // Verbinding met de database mogelijk maken
        public static MySqlConnection MakeConnection()
        {
            // Alle eigenschappen invullen
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "Eindwerk",
                UserID = "root",
                Password = "usbw",
                ConnectionTimeout = 60,
                Port = 3307,
                AllowZeroDateTime = true,
            };

            // Eigenschappen invullen in Connection
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);

            // Verbinding openen
            conn.Open();

            // Verbinding doorgeven
            return conn;
        }
    }
}
