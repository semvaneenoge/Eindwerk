using MySql.Data.MySqlClient;
using prjEindwerk_LotsOfLili.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEindwerk_LotsOfLili.DA
{
    public class ProductDA
    {
        public static void Invoegen()
        {
            MySqlConnection conn = Database.MakeConnection();

            PictureBox pictureBox = new PictureBox();

            string query = "select foto from eindwerk.tblProducten where ProductID = @ProductID";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ProductID", 1);
            byte[] fotoBytes = cmd.ExecuteScalar() as byte[];

            if ( fotoBytes != null )
            {
                MemoryStream ms = new MemoryStream(fotoBytes);

                pictureBox.Image = Image.FromStream(ms);
            }
            else
            {
                MessageBox.Show("Foto is niet gevonden in de database.");
            }
        }
    }
}
