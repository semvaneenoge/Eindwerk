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
    public class LoginDA
    {
        public static bool LoginValidation(Login L)
        {
            bool blnLogin = false;

            // verbinding met databank
            MySqlConnection conn = Database.MakeConnection();

            string quary = "SELECT count(1) from Eindwerk.tblLogin where Email = @Email and Wachtwoord = @Wachtwoord";
            // Voert sql statements uit
            MySqlCommand mySqlCmd = new MySqlCommand(quary, conn);
            // Soort commando --> text
            mySqlCmd.CommandType = CommandType.Text;
            // Parameters toevoegen
            mySqlCmd.Parameters.AddWithValue("@Email", L.Email);
            mySqlCmd.Parameters.AddWithValue("@Wachtwoord", L.Wachtwoord);

            int count = Convert.ToInt32(mySqlCmd.ExecuteScalar()); // Een waarde uit de databank opvragen

            if (count == 1)
            {
                // Correct inloggen --> boolean = true
                blnLogin = true;
            }
            else
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord is fout.");
            }

            conn.Close();
            return blnLogin;
        }

        public static void Registreren(Login L)
        {
            // verbinding met databank
            MySqlConnection conn = Database.MakeConnection();

            string quary = "INSERT INTO Eindwerk.tblLogin(Adres, Email, Naam, Telefoon, Voornaam, Wachtwoord) VALUES (@Adres, @Email, @Naam, @Telefoon, @Voornaam, @Wachtwoord)";
            // Voert sql statements uit
            MySqlCommand mySqlCmd = new MySqlCommand(quary, conn);
            // Soort commando --> text
            mySqlCmd.CommandType = CommandType.Text;
            // Parameters toevoegen
            mySqlCmd.Parameters.AddWithValue("@Adres", L.Adres);
            mySqlCmd.Parameters.AddWithValue("@Email", L.Email);
            mySqlCmd.Parameters.AddWithValue("@Naam", L.Naam);
            mySqlCmd.Parameters.AddWithValue("@Telefoon", L.Telefoon);
            mySqlCmd.Parameters.AddWithValue("@Voornaam", L.Voornaam);
            mySqlCmd.Parameters.AddWithValue("@Wachtwoord", L.Wachtwoord);

            // Uitvoeren van commando
            mySqlCmd.ExecuteScalar();

            MessageBox.Show("U bent geregistreerd");
            conn.Close();
        }
    }
}
