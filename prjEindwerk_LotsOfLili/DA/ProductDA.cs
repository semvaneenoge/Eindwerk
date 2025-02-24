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
        // 
        // Oppassen voor webp bestanden
        // 
        // Fotos agenda aanpassen --> achtergrond verwijderen (eerst kijken om foto te updaten)

        public List<(int ID, string Naam, Double Prijs, Image Foto)> Horloges = new List<(int ID, string Naam, Double Prijs, Image Foto)>();
        public List<(int ID, string Naam, Double Prijs, Image Foto)> Agendas = new List<(int ID, string Naam, Double Prijs, Image Foto)>();
        public List<(int ID, string Naam, Double Prijs, Image Foto)> Portemonnees = new List<(int ID, string Naam, Double Prijs, Image Foto)>();
        public List<(int ID, string Naam, Double Prijs, Image Foto)> Pins = new List<(int ID, string Naam, Double Prijs, Image Foto)>();

        int groupSize = 6;

        public void HorlogesInvoegen()
        {
            try
            {
                using (MySqlConnection conn = Database.MakeConnection())
                {
                    string query = "select * from eindwerk.tblHorloge";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int productID = Convert.ToInt32(reader["ID"]);
                                string productNaam = reader["Naam"].ToString();
                                double productPrijs = Convert.ToDouble(reader["Prijs"]);
                                Image productFoto = null;
                                byte[] fotoBytes = reader["Foto"] as byte[];

                                if (fotoBytes != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(fotoBytes))
                                    {
                                        productFoto = Image.FromStream(ms);

                                        if (!Horloges.Any(p => p.ID == productID))
                                        {
                                            Horloges.Add((productID, productNaam, productPrijs, productFoto));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                int placeholdersNeeded = (groupSize - (Horloges.Count % groupSize)) % groupSize;

                for (int i = 0; i < placeholdersNeeded; i++)
                {
                    Horloges.Add((0, "Empty slot", 0.0, null));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}");
            }
        }

        public void AgendasInvoegen()
        {
            try
            {
                using (MySqlConnection conn = Database.MakeConnection())
                {
                    string query = "select * from eindwerk.tblAgenda";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int productID = Convert.ToInt32(reader["ID"]);
                                string productNaam = reader["Naam"].ToString();
                                double productPrijs = Convert.ToDouble(reader["Prijs"]);
                                Image productFoto = null;
                                byte[] fotoBytes = reader["Foto"] as byte[];

                                if (fotoBytes != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(fotoBytes))
                                    {
                                        productFoto = Image.FromStream(ms);

                                        if (!Agendas.Any(p => p.ID == productID))
                                        {
                                            Agendas.Add((productID, productNaam, productPrijs, productFoto));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                int placeholdersNeeded = (groupSize - (Agendas.Count % groupSize)) % groupSize;

                for (int i = 0; i < placeholdersNeeded; i++)
                {
                    Agendas.Add((0, "Empty slot", 0.0, null));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}");
            }
        }

        public void PortemonneesInvoegen()
        {
            try
            {
                using (MySqlConnection conn = Database.MakeConnection())
                {
                    string query = "select * from eindwerk.tblPortemonnee";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int productID = Convert.ToInt32(reader["ID"]);
                                string productNaam = reader["Naam"].ToString();
                                double productPrijs = Convert.ToDouble(reader["Prijs"]);
                                Image productFoto = null;
                                byte[] fotoBytes = reader["Foto"] as byte[];

                                if (fotoBytes != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(fotoBytes))
                                    {
                                        productFoto = Image.FromStream(ms);

                                        if (!Portemonnees.Any(p => p.ID == productID))
                                        {
                                            Portemonnees.Add((productID, productNaam, productPrijs, productFoto));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                int placeholdersNeeded = (groupSize - (Portemonnees.Count % groupSize)) % groupSize;

                for (int i = 0; i < placeholdersNeeded; i++)
                {
                    Portemonnees.Add((0, "Empty slot", 0.0, null));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}");
            }
        }
    }
}
