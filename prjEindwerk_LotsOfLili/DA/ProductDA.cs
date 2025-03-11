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
using Org.BouncyCastle.Math;

namespace prjEindwerk_LotsOfLili.DA
{
    public class ProductDA
    {

        // --- notes ---
        //
        // Oppassen voor webp bestanden !!!

        public List<(int ID, string Naam, Double Prijs, Image Foto)> Agendas = new List<(int ID, string Naam, Double Prijs, Image Foto)>();
        public List<(int ID, string Naam, Double Prijs, Image Foto)> Horloges = new List<(int ID, string Naam, Double Prijs, Image Foto)>();
        public List<(int ID, string Naam, Double Prijs, Image Foto)> Portemonnees = new List<(int ID, string Naam, Double Prijs, Image Foto)>();
        public List<(int ID, string Naam, Double Prijs, Image Foto)> Pins = new List<(int ID, string Naam, Double Prijs, Image Foto)>();

        int groupSize = 6;

        public void AgendasInvoegen()
        {
            // Verbinding met databank
            MySqlConnection conn = Database.MakeConnection();
                
            try
            {
                // Producten ophalen uit table
                string query = "select * from eindwerk.tblAgenda";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Data lezen uit database
                MySqlDataReader reader = cmd.ExecuteReader();

                // Reader uitlezen
                while (reader.Read())
                {
                    // Gegevens bewaren
                    int productID = Convert.ToInt32(reader["ID"]);
                    string productNaam = reader["Naam"].ToString();
                    double productPrijs = Convert.ToDouble(reader["Prijs"]);
                    Image productFoto = null;
                    byte[] fotoBytes = reader["Foto"] as byte[];

                    // Controle of afbeelding bestaat
                    if (fotoBytes != null)
                    {
                        // Afbeelding omzetten en bewaren
                        MemoryStream ms = new MemoryStream(fotoBytes);
                        productFoto = Image.FromStream(ms);

                        // Items toevoeven aan List
                        Agendas.Add((productID, productNaam, productPrijs, productFoto));           
                    }
                }

                // Berekening van lege slots voor weergave van producten
                int placeholdersNeeded = (groupSize - (Agendas.Count % groupSize)) % groupSize;

                // Lege slots toevoegen voor weergave
                for (int i = 0; i < placeholdersNeeded; i++)
                {
                    Agendas.Add((0, "Empty slot", 0.0, null));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}\n" +
                    $"Producten zijn niet gevonden");
            }
            finally
            {
                // Verbdinging sluiten
                conn.Close();
            }
        }

        public void HorlogesInvoegen()
        {
            // Verbinding met databank
            MySqlConnection conn = Database.MakeConnection();

            try
            {
                // Producten ophalen uit table
                string query = "select * from eindwerk.tblHorloge";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Data lezen uit database
                while (reader.Read())
                {
                    // Gegevens bewaren
                    int productID = Convert.ToInt32(reader["ID"]);
                    string productNaam = reader["Naam"].ToString();
                    double productPrijs = Convert.ToDouble(reader["Prijs"]);
                    Image productFoto = null;
                    byte[] fotoBytes = reader["Foto"] as byte[];

                    // Controle op afbeelding
                    if (fotoBytes != null)
                    {
                        // Afbeelding omzetten en bewaren
                        MemoryStream ms = new MemoryStream(fotoBytes);
                        productFoto = Image.FromStream(ms);

                        // Item toevoegen aan List
                        Horloges.Add((productID, productNaam, productPrijs, productFoto));
                    }
                }

                // Berekening van lege slots voor weergave van producten
                int placeholdersNeeded = (groupSize - (Horloges.Count % groupSize)) % groupSize;

                // Lege slots toevoegen voor weergave
                for (int i = 0; i < placeholdersNeeded; i++)
                {
                    Horloges.Add((0, "Empty slot", 0.0, null));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}\n" +
                    $"Producten zijn niet gevonden");
            }
            finally
            {
                // Verbinding sluiten
                conn.Close();
            }
        }

        public void PortemonneesInvoegen()
        {
            MySqlConnection conn = Database.MakeConnection();

            try
            {
                // Producten ophalen uit table
                string query = "select * from eindwerk.tblPortemonnee";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Data lezen uit database
                while (reader.Read())
                {
                    // Gegevens bewaren 
                    int productID = Convert.ToInt32(reader["ID"]);
                    string productNaam = reader["Naam"].ToString();
                    double productPrijs = Convert.ToDouble(reader["Prijs"]);
                    Image productFoto = null;
                    byte[] fotoBytes = reader["Foto"] as byte[];

                    // Controle op afbeelding
                    if (fotoBytes != null)
                    {
                        // Afbeelding omzetten en bewaren
                        MemoryStream ms = new MemoryStream(fotoBytes);
                        productFoto = Image.FromStream(ms);

                        // Item toevoegen aan List
                        Portemonnees.Add((productID, productNaam, productPrijs, productFoto));
                    }
                }

                // Berekening van lege slots voor weergave van producten
                int placeholdersNeeded = (groupSize - (Portemonnees.Count % groupSize)) % groupSize;

                // Lege slots toevoegen voor weergave
                for (int i = 0; i < placeholdersNeeded; i++)
                {
                    Portemonnees.Add((0, "Empty slot", 0.0, null));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}\n" +
                    $"Producten zijn niet gevonden");
            }
            finally
            {
                // Verbinding sluiten
                conn.Close();
            }
        }

        public void PinsInvoegen()
        {
            MySqlConnection conn = Database.MakeConnection();

            try
            {
                // Producten ophalen uit table
                string query = "select * from eindwerk.tblPin";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Data lezen uit database
                while (reader.Read())
                {
                    // Gegevens bewaren 
                    int productID = Convert.ToInt32(reader["ID"]);
                    string productNaam = reader["Naam"].ToString();
                    double productPrijs = Convert.ToDouble(reader["Prijs"]);
                    Image productFoto = null;
                    byte[] fotoBytes = reader["Foto"] as byte[];

                    // Controle op afbeelding
                    if (fotoBytes != null)
                    {
                        // Afbeelding omzetten en bewaren
                        MemoryStream ms = new MemoryStream(fotoBytes);
                        productFoto = Image.FromStream(ms);

                        // Item toevoegen aan List
                        Pins.Add((productID, productNaam, productPrijs, productFoto));
                    }
                }

                // Berekening van lege slots voor weergave van producten
                int placeholdersNeeded = (groupSize - (Pins.Count % groupSize)) % groupSize;

                // Lege slots toevoegen voor weergave
                for (int i = 0; i < placeholdersNeeded; i++)
                {
                    Pins.Add((0, "Empty slot", 0.0, null));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}\n" +
                    $"Producten zijn niet gevonden");
            }
            finally
            {
                // Verbinding sluiten
                conn.Close();
            }
        }

        public static void ProductToevoegen(string productType, string productNaam, double productPrijs, Image productFoto)
        {
            MySqlConnection conn = Database.MakeConnection();

            try
            {
                // Bepalen welke table gebruikt wordt
                string tbl = "";

                switch (productType)
                {
                    case "Agenda":
                        tbl = "eindwerk.tblAgenda";
                        break;
                    case "Horloge":
                        tbl = "eindwerk.tblHorloge";
                        break;
                    case "Portemonnee":
                        tbl = "eindwerk.tblPortemonnee";
                        break;
                    case "Pin":
                        tbl = "eindwerk.tblPin";
                        break;
                }

                // Toevoegen van product
                string query = $"insert into {tbl} (Naam, Prijs, Foto) values (@Naam, @Prijs, @Foto)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Naam", productNaam);
                cmd.Parameters.AddWithValue("@Prijs", productPrijs);

                byte[] imageBytes = null;

                // Afbeelding omzetten naar byte array (als het bestaat)
                if (productFoto != null)
                {
                    MemoryStream ms = new MemoryStream();

                    productFoto.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }

                cmd.Parameters.AddWithValue("@Foto", imageBytes);

                // query uitvoeren
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product is succesvol toegevoegd.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden bij het toevoeven van het product: {ex.Message}");
            }
            finally
            {
                // Verbinding sluiten
                conn.Close();
            }
        }

        public static void ProductVerwijderen(string productType, string productNaam)
        {
            MySqlConnection conn = Database.MakeConnection();

            try
            {
                // Bepalen welke table gebruikt wordt
                string tbl = "";

                switch (productType)
                {
                    case "Agenda":
                        tbl = "eindwerk.tblAgenda";
                        break;
                    case "Horloge":
                        tbl = "eindwerk.tblHorloge";
                        break;
                    case "Portemonnee":
                        tbl = "eindwerk.tblPortemonnee";
                        break;
                    case "Pin":
                        tbl = "eindwerk.tblPin";
                        break;
                }

                // Verwijderen van product
                string query = $"delete from {tbl} where Naam = @Naam";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Naam", productNaam);

                // query uitvoeren en waarde opslaan (controle op verandering)
                int aantalVeranderingen = cmd.ExecuteNonQuery();

                if (aantalVeranderingen > 0)
                {
                    MessageBox.Show("Product succesvol verwijderd.");
                }
                else
                {
                    MessageBox.Show("Geen product gevonden met deze naam.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden bij het verwijderen van het product: {ex.Message}");
            }
            finally
            {
                // Verbinding sluiten
                conn.Close();
            }
        }
    }
}
