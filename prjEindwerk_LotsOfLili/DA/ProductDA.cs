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
using System.Diagnostics;

namespace prjEindwerk_LotsOfLili.DA
{
    public class ProductDA
    {

        // ---Notes---
        //
        // Meer producten

        public List<(int ID, string Naam, Image Foto)> Horloges = new List<(int ID, string Name, Image Foto)>();
        public List<(int ID, string Naam, Image Foto)> Agendas = new List<(int ID, string Name, Image Foto)>();
        public List<(int ID, string Naam, Image Foto)> Portemonnees = new List<(int ID, string Name, Image Foto)>();
        public List<(int ID, string Naam, Image Foto)> Pins = new List<(int ID, string Name, Image Foto)>();

        public void HorlogesInvoegen()
        {
            try
            {
                using (MySqlConnection conn = Database.MakeConnection())
                {
                    string query = "select ID, Foto, Naam from eindwerk.tblHorloge";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int ID = Convert.ToInt32(reader["ID"]);
                                string productNaam = reader["Naam"].ToString();
                                Image img = null;
                                byte[] fotoBytes = reader["Foto"] as byte[];

                                if (fotoBytes != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(fotoBytes))
                                    {
                                        img = Image.FromStream(ms);

                                        if (!Horloges.Any(p => p.ID == ID))
                                        {
                                            Horloges.Add((ID, productNaam, img));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}");
            }
        }
    }
}
