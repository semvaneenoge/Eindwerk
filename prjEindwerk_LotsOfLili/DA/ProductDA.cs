﻿using MySql.Data.MySqlClient;
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
        // Oppassen voor webp bestanden !!!
        // 
        // Fotos agenda aanpassen --> achtergrond verwijderen (eerst kijken om foto te updaten in database / als admin)
        //
        // Code proberen veranderen dat ik niet direct of volledig begrijp (kunnen uitleggen) --> Any
        //
        // Nieuwe portemonnee terug toevoegen Keecie

        public List<(int ID, string Naam, Double Prijs, Image Foto)> Agendas = new List<(int ID, string Naam, Double Prijs, Image Foto)>();
        public List<(int ID, string Naam, Double Prijs, Image Foto)> Horloges = new List<(int ID, string Naam, Double Prijs, Image Foto)>();
        public List<(int ID, string Naam, Double Prijs, Image Foto)> Portemonnees = new List<(int ID, string Naam, Double Prijs, Image Foto)>();
        public List<(int ID, string Naam, Double Prijs, Image Foto)> Pins = new List<(int ID, string Naam, Double Prijs, Image Foto)>();

        int groupSize = 6;

        public void AgendasInvoegen()
        {
            try
            {
                MySqlConnection conn = Database.MakeConnection();
                
                string query = "select * from eindwerk.tblAgenda";

                MySqlCommand cmd = new MySqlCommand(query, conn);


                MySqlDataReader reader = cmd.ExecuteReader();
                        
                while (reader.Read())
                {
                    int productID = Convert.ToInt32(reader["ID"]);
                    string productNaam = reader["Naam"].ToString();
                    double productPrijs = Convert.ToDouble(reader["Prijs"]);
                    Image productFoto = null;
                    byte[] fotoBytes = reader["Foto"] as byte[];

                    if (fotoBytes != null)
                    {
                        MemoryStream ms = new MemoryStream(fotoBytes);
                                    
                        productFoto = Image.FromStream(ms);

                        Agendas.Add((productID, productNaam, productPrijs, productFoto));           
                    }
                }

                int placeholdersNeeded = (groupSize - (Agendas.Count % groupSize)) % groupSize;

                for (int i = 0; i < placeholdersNeeded; i++)
                {
                    Agendas.Add((0, "Empty slot", 0.0, null));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}");
            }
        }

        public void HorlogesInvoegen()
        {
            try
            {
                MySqlConnection conn = Database.MakeConnection();
                
                string query = "select * from eindwerk.tblHorloge";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                        
                while (reader.Read())
                {
                    int productID = Convert.ToInt32(reader["ID"]);
                    string productNaam = reader["Naam"].ToString();
                    double productPrijs = Convert.ToDouble(reader["Prijs"]);
                    Image productFoto = null;
                    byte[] fotoBytes = reader["Foto"] as byte[];

                    if (fotoBytes != null)
                    {
                        MemoryStream ms = new MemoryStream(fotoBytes);
                                    
                        productFoto = Image.FromStream(ms);

                        Horloges.Add((productID, productNaam, productPrijs, productFoto));      
                    }
                }

                int placeholdersNeeded = (groupSize - (Horloges.Count % groupSize)) % groupSize;

                for (int i = 0; i < placeholdersNeeded; i++)
                {
                    Horloges.Add((0, "Geen product", 0.0, null));
                }

                conn.Close();
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
                MySqlConnection conn = Database.MakeConnection();
                
                string query = "select * from eindwerk.tblPortemonnee";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                        
                while (reader.Read())
                {
                    int productID = Convert.ToInt32(reader["ID"]);
                    string productNaam = reader["Naam"].ToString();
                    double productPrijs = Convert.ToDouble(reader["Prijs"]);
                    Image productFoto = null;
                    byte[] fotoBytes = reader["Foto"] as byte[];

                    if (fotoBytes != null)
                    {
                        MemoryStream ms = new MemoryStream(fotoBytes);
                        
                        productFoto = Image.FromStream(ms);

                        Portemonnees.Add((productID, productNaam, productPrijs, productFoto));
                    }
                }

                int placeholdersNeeded = (groupSize - (Portemonnees.Count % groupSize)) % groupSize;

                for (int i = 0; i < placeholdersNeeded; i++)
                {
                    Portemonnees.Add((0, "Empty slot", 0.0, null));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}");
            }
        }

        public void PinsInvoegen()
        {
            try
            {
                MySqlConnection conn = Database.MakeConnection();
                
                string query = "select * from eindwerk.tblPin";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int productID = Convert.ToInt32(reader["ID"]);
                    string productNaam = reader["Naam"].ToString();
                    double productPrijs = Convert.ToDouble(reader["Prijs"]);
                    Image productFoto = null;
                    byte[] fotoBytes = reader["Foto"] as byte[];

                    if (fotoBytes != null)
                    {
                        MemoryStream ms = new MemoryStream(fotoBytes);

                        productFoto = Image.FromStream(ms);

                        Pins.Add((productID, productNaam, productPrijs, productFoto));
                    }
                }

                int placeholdersNeeded = (groupSize - (Pins.Count % groupSize)) % groupSize;

                for (int i = 0; i < placeholdersNeeded; i++)
                {
                    Pins.Add((0, "Empty slot", 0.0, null));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}");
            }
        }
    }
}
