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
        public static bool LoginValidation(Gebruikers G)
        {
            bool blnLogin = false;

            // verbinding met databank
            MySqlConnection conn = Database.MakeConnection();

            string quary = "SELECT count(1) from Eindwerk.tblgebruikers where Email = @Email and Wachtwoord = @Wachtwoord";
            // Voert sql statements uit
            MySqlCommand mySqlCmd = new MySqlCommand(quary, conn);
            // Soort commando --> text
            mySqlCmd.CommandType = CommandType.Text;
            // Parameters toevoegen
            mySqlCmd.Parameters.AddWithValue("@Email", G.Email);
            mySqlCmd.Parameters.AddWithValue("@Wachtwoord", G.Wachtwoord);

            int count = Convert.ToInt32(mySqlCmd.ExecuteScalar()); // Een waarde uit de databank opvragen

            if (count == 1)
            {
                // Correct inloggen --> boolean = true
                blnLogin = true;
            }

            conn.Close();
            return blnLogin;
        }

        public static void Registreren(Gebruikers G)
        {
            // verbinding met databank
            MySqlConnection conn = Database.MakeConnection();

            string quary = "INSERT INTO Eindwerk.tblgebruikers(Adres, Email, Naam, Postcode, Telefoon, Voornaam, Wachtwoord) VALUES (@Adres, @Email, @Naam, @Postcode, @Telefoon, @Voornaam, @Wachtwoord)";
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
            mySqlCmd.ExecuteScalar();

            MessageBox.Show("U bent geregistreerd");
            conn.Close();
        }
    }
}
