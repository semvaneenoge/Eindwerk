using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEindwerk_LotsOfLili
{
    public class Cart
    {
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public int Aantal { get; set; }

        public Cart(string naam, double prijs, int aantal)
        {
            Naam = naam;
            Prijs = prijs;
            Aantal = aantal;
        }
    }
}
