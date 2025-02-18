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

        // ---Notes---
        //
        // Dictionary usage --> foreach = get all images... (chatgpt, ask for usage)

        public bool HorlogesInvoegen(int ID, PictureBox pictureBoxTest, Label labelTest)
        {
            Dictionary<int, Image> imagesByID = new Dictionary<int, Image>();

            try
            {
                using (MySqlConnection conn = Database.MakeConnection())
                {
                    string query = "select Foto, Naam from eindwerk.tblHorloge where ID = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] fotoBytes = reader["Foto"] as byte[];
                                string productNaam = reader["Naam"].ToString();

                                if (fotoBytes != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(fotoBytes))
                                    {
                                        Image img = Image.FromStream(ms);
                                        pictureBoxTest.Image = img;
                                        imagesByID.Add(ID, img);
                                    }
                                }
                                else
                                {
                                    pictureBoxTest.Image = null;
                                    MessageBox.Show("Foto is niet gevonden in de database.");
                                }

                                labelTest.Text = productNaam;
                                return true;
                            }
                            else
                            {
                                labelTest.Text = "Geen product gevonden";
                                pictureBoxTest.Image = null;
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}");
                return false;
            }
        }
    }
}
