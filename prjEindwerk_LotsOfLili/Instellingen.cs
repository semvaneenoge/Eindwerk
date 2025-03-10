using prjEindwerk_LotsOfLili.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using prjEindwerk_LotsOfLili.DA;

namespace prjEindwerk_LotsOfLili
{
    public partial class Instellingen : Form
    {
        public string userEmail { get; set; }

        public List<Cart> Cart;

        public string customerName;

        int pogingen;

        public Instellingen()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmHome Home = new frmHome();
            Home.customerNameHome = customerName;
            Home.Cart = Cart;
            Home.Show();
            this.Hide();
        }

        private void btnWWVeranderen_Click(object sender, EventArgs e)
        {
            Gebruikers G = new Gebruikers();
            G.Email = userEmail;
            
            string ingegevenWW = Interaction.InputBox("Gelieve uw huidig wachtwoord in te vullen.", "Controle wachtwoord");

            string opgeslagenWW = "";
            GebruikersDA.WWControle(G, out opgeslagenWW);

            if (string.IsNullOrEmpty(opgeslagenWW))
            {
                MessageBox.Show("Er is een probleem met het ophalen van het wachtwoord.");
                return;
            }

            while (pogingen < 3)
            {
                if (ingegevenWW == opgeslagenWW)
                {
                    string newWW1 = Interaction.InputBox("Gelieve uw nieuw wachtwoord in the geven.", "Nieuw wachtwoord");

                    if (string.IsNullOrEmpty(newWW1))
                    {
                        MessageBox.Show("Nieuw wachtwoord mag niet leeg zijn!", "");
                        continue;
                    }

                    if (newWW1 == ingegevenWW)
                    {
                        MessageBox.Show("Wachtwoord mag niet hetzelfde zijn als de vorige!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string newWW2 = Interaction.InputBox("Gelieve uw nieuw wachtwoord herhalen.", "Controle nieuw wachtwoord");

                        if (newWW2 != newWW1)
                        {
                            MessageBox.Show("Wachtwoorden komen niet overeen!", "Fout wachtwoord");
                        }
                        else
                        {
                            G.Wachtwoord = opgeslagenWW;
                            GebruikersDA.WWVeranderen(G, newWW2);
                            MessageBox.Show("Uw wachtwoord is veranderd.", "");
                            break;
                        }
                    }

                    
                }
                else
                {
                    pogingen++;
                    if (pogingen == 3)
                    {
                        MessageBox.Show("Te veel pogingen! Probeer het later opnieuw.");
                    }
                }
            }
        }
    }
}
