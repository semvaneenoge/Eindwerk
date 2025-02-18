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
        public bool HorlogesInvoegen(int ID, PictureBox pictureBoxTest, Label labelTest)
        {
            MySqlConnection conn = Database.MakeConnection();

            string query = "select Foto, Naam from eindwerk.tblHorloge where ID = @ID";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                byte[] fotoBytes = reader["Foto"] as byte[];
                string productNaam = reader["Naam"].ToString();

                if (fotoBytes != null)
                {
                    MemoryStream ms = new MemoryStream(fotoBytes);

                    pictureBoxTest.Image = Image.FromStream(ms);
                }
                else
                {
                    pictureBoxTest.Image = null;
                    MessageBox.Show("Foto is niet gevonden in de database.");
                }

                labelTest.Text = productNaam;

                conn.Close();
                return true;
            }
            else
            {
                labelTest.Text = "Geen product gevonden";
                pictureBoxTest = null;
                conn.Close();
                return false;
            }
        }
    }
}
