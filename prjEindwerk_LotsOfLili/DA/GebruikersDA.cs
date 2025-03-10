using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using prjEindwerk_LotsOfLili.Helper;
using prjEindwerk_LotsOfLili.Model;

namespace prjEindwerk_LotsOfLili.DA
{
    public class GebruikersDA
    {
        public static bool LoginValidation(Gebruikers G, out bool isAdmin, out string Naam)
        {
            bool blnLogin = false;
            isAdmin = false;
            Naam = "";

            // verbinding met databank
            MySqlConnection conn = Database.MakeConnection();

            string query = "SELECT count(1), Admin, Voornaam, Naam from Eindwerk.tblgebruikers where Email = @Email and Wachtwoord = @Wachtwoord";
            // Voert sql statements uit
            MySqlCommand mySqlCmd = new MySqlCommand(query, conn);
            // Soort commando --> text
            mySqlCmd.CommandType = CommandType.Text;
            // Parameters toevoegen
            mySqlCmd.Parameters.AddWithValue("@Email", G.Email);
            mySqlCmd.Parameters.AddWithValue("@Wachtwoord", G.Wachtwoord);

            MySqlDataReader reader = mySqlCmd.ExecuteReader();

            if (reader.Read())
            {
                int count = reader.GetInt32(0);

                if (count == 1)
                {
                    isAdmin = reader.GetInt32(1) == 1;
                    Naam = reader.GetString(2) + " " + reader.GetString(3);
                    blnLogin = true;
                }
            }

            conn.Close();
            return blnLogin;
        }

        public static void Registreren(Gebruikers G, out string Naam)
        {
            Naam = "";

            // verbinding met databank
            MySqlConnection conn = Database.MakeConnection();

            try
            {
                string check = "select count(*) from Eindwerk.tblgebruikers where Email = @Email";

                MySqlCommand cmd = new MySqlCommand(check, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Email", G.Email);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Dit email is al in gebruik. Gelieve een ander email te gebruiken.");
                    conn.Close();
                    return;
                }

                string quary = "INSERT INTO Eindwerk.tblgebruikers(Adres, Email, Naam, Postcode, Telefoon, Voornaam, Wachtwoord) " +
                               "VALUES (@Adres, @Email, @Naam, @Postcode, @Telefoon, @Voornaam, @Wachtwoord)";
                // Voert sql statements uit
                MySqlCommand mySqlCmd = new MySqlCommand(quary, conn);
                // Soort commando --> text
                mySqlCmd.CommandType = CommandType.Text;
                // Parameters toevoegen
                mySqlCmd.Parameters.AddWithValue("@Adres", G.Adres);
                mySqlCmd.Parameters.AddWithValue("@Email", G.Email);
                mySqlCmd.Parameters.AddWithValue("@Naam", G.Naam);
                mySqlCmd.Parameters.AddWithValue("@Postcode", G.Postcode);
                mySqlCmd.Parameters.AddWithValue("@Telefoon", G.Telefoon);
                mySqlCmd.Parameters.AddWithValue("@Voornaam", G.Voornaam);
                mySqlCmd.Parameters.AddWithValue("@Wachtwoord", G.Wachtwoord);

                // Uitvoeren van commando
                mySqlCmd.ExecuteNonQuery();

                Naam = G.Voornaam + " " + G.Naam;

                MessageBox.Show("U bent geregistreerd");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden: " + ex.Message);
            }
            // sluit de database (ook als er een fout is)
            finally
            {
                conn.Close();
            }
        }

        public static void WWControle(Gebruikers G, out string currentWW)
        {
            currentWW = "";

            MySqlConnection conn = Database.MakeConnection();

            try
            {
                string query = "select Wachtwoord from Eindwerk.tblGebruikers where Email = @Email";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Email", G.Email);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    currentWW = result.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden" + ex.Message);
            }

            conn.Close();
        }

        public static void WWVeranderen(Gebruikers G, string newWW)
        {
            MySqlConnection conn = Database.MakeConnection();

            string query = "UPDATE Eindwerk.tblGebruikers SET Wachtwoord = @newWW WHERE Email = @Email and tblGebruikers.Wachtwoord = @Wachtwoord";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Email", G.Email);
            cmd.Parameters.AddWithValue("@Wachtwoord", G.Wachtwoord);
            cmd.Parameters.AddWithValue("@newWW", newWW);

            cmd.ExecuteScalar();
            conn.Close();
        }
    }
}
