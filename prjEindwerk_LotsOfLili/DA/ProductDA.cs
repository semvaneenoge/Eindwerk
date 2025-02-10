using MySql.Data.MySqlClient;
using prjEindwerk_LotsOfLili.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEindwerk_LotsOfLili.DA
{
    public class ProductDA
    {
        public static void Invoegen()
        {
            MySqlConnection conn = Database.MakeConnection();

            string query = "select Foto from tblProducten where ProductID = @ProductID";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@ProductID", 1);
            }
        }
    }
}
