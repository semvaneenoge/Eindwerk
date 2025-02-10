using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEindwerk_LotsOfLili.Model
{
    public class Gebruikers
    {
        public bool Admin {  get; set; }

        public string Adres { get; set; }

        public string Email { get; set; }

        public string Naam { get; set; }

        public int Postcode { get; set; }

        public string Telefoon { get; set; }

        public string Voornaam { get; set; }

        public string Wachtwoord { get; set; }
    }
}
