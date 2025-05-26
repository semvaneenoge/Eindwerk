using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using prjEindwerk_LotsOfLili.Helper;
using prjEindwerk_LotsOfLili.Model;
using Newtonsoft.Json;

namespace prjEindwerk_LotsOfLili.DA
{
    public class BestellingDA
    {
        public void SaveCartAsJSON (int klantID, List<Cart> cart)
        {
            // Verbinding met databank
            MySqlConnection conn = Database.MakeConnection();

            string bestellingJSON = JsonConvert.SerializeObject(cart);
            DateTime datum = DateTime.Now.Date;

            string query = "insert into tblBestelling (klantID, bestelling, datum) values (@klantID, @bestelling, @datum)";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@klantID", klantID);
            cmd.Parameters.AddWithValue("@bestelling", bestellingJSON);
            cmd.Parameters.AddWithValue("@datum", datum);

            cmd.ExecuteNonQuery();
        }

        public List<(int klantID, string klantNaam)> GetCustomerNames()
        {
            // Verbinding met databank
            MySqlConnection conn = Database.MakeConnection();

            List<(int klantID, string klantNaam)> customerNames = new List<(int klantID, string klantNaam)>();

            string query = "select distinct gebruikerID, Voornaam, Naam from tblGebruikers join tblbestelling on tblbestelling.klantID = gebruikerID order by Naam, Voornaam";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("gebruikerID");
                string customerName = $"{reader.GetString("Naam")} {reader.GetString("Voornaam")}";
                customerNames.Add((id, customerName));
            }
                
            conn.Close();
            return customerNames;
        }

        public List<(int bestellingID, DateTime datum)> GetOrdersByCustomer (int klantID)
        {
            // Verbinding met databank
            MySqlConnection conn = Database.MakeConnection();

            List<(int, DateTime)> orders = new List<(int, DateTime)>();

            string query = "select bestellingID, datum from tblBestelling where klantID = @klantID order by datum desc";

            MySqlCommand cmd = new MySqlCommand (query, conn);

            cmd.Parameters.AddWithValue("@klantID", klantID);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt16("bestellingID");
                DateTime date = reader.GetDateTime("datum");
                orders.Add((id, date));
            }

            conn.Close();
            return orders;
        }

        public List<Cart> GetOrderDetails (int bestellingID)
        {
            string orderJSON = "";

            // Verbinding met databank
            MySqlConnection conn = Database.MakeConnection();

            string query = "select bestelling from tblBestelling where bestellingID = @ID";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ID", bestellingID);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                orderJSON = reader.GetString("bestelling");
            }

            conn.Close();
            return JsonConvert.DeserializeObject<List<Cart>>(orderJSON);
        }
    }
}
