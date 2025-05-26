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
        public bool isAdmin;

        public int userID;

        public string userEmail;

        public List<Cart> Cart;

        public string customerName;

        string ingegevenWW, opgeslagenWW;

        public Instellingen()
        {
            InitializeComponent();

            // --- notes ---
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            // Waarden doorgeven en Home tonen
            frmHome Home = new frmHome();
            Home.userID = userID;
            Home.customerNameHome = customerName;
            Home.userEmail = userEmail;
            Home.Cart = Cart;
            Home.isAdmin = isAdmin;
            Home.Show();
            this.Hide();
        }

        private void Instellingen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Waarden doorgeven en Home tonen
            frmHome Home = new frmHome();
            Home.userID = userID;
            Home.customerNameHome = customerName;
            Home.userEmail = userEmail;
            Home.Cart = Cart;
            Home.isAdmin = isAdmin;
            Home.Show();
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Gebruikers G = new Gebruikers();
            G.Email = userEmail;

            // Textbox waarde opvangen
            ingegevenWW = txtWW.Text;

            // Controle of het leeg is
            if (string.IsNullOrEmpty(ingegevenWW))
            {
                MessageBox.Show("Gelieve een wachtwoord in te geven!", "");
            }

            // Controle methode uitvoeren
            opgeslagenWW = "";
            GebruikersDA.WWControle(G, out opgeslagenWW);

            // Controle ophalen van wachtwoord
            if (string.IsNullOrEmpty(opgeslagenWW))
            {
                MessageBox.Show("Er is een probleem met het ophalen van het wachtwoord.");
                return;
            }

            // Controle of ingegeven wachtwoord overeenkomt met database
            if (ingegevenWW == opgeslagenWW)
            {
                btnOk.Visible = false;
                btnWWVeranderen.Visible = true;
                lblWW.Visible = false;
                lblNieuwWW.Visible = true;
                lblControleWW.Visible = true;
                txtWW.Visible = false;
                txtNieuwWW.Visible = true;
                txtControleWW.Visible = true;
            }
            else if (ingegevenWW != opgeslagenWW && !string.IsNullOrEmpty(ingegevenWW))
            {
                MessageBox.Show("Wachtwoord is fout.", "");
            }

            txtWW.Clear();
        }

        private void btnWWVeranderen_Click(object sender, EventArgs e)
        {
            Gebruikers G = new Gebruikers();
            G.Email = userEmail;

            // Textbox waarde eerste wachtwoord opvangen
            string newWW1 = txtNieuwWW.Text;

            // Controle nieuw wachtwoord gelijk als oude
            if (newWW1 == ingegevenWW)
            {
                MessageBox.Show("Wachtwoord mag niet hetzelfde zijn als de vorige!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNieuwWW.Clear();
                txtControleWW.Clear();
            }
            else
            {
                // Textbox waarde tweede wachtwoord opvangen
                string newWW2 = txtControleWW.Text;

                // Controle of eerste wachtwoord leeg is
                if (string.IsNullOrEmpty(newWW1))
                {
                    MessageBox.Show("Nieuw wachtwoord mag niet leeg zijn!", "");
                    return;
                }

                // Controle of wachtwoorden overeenkomen
                if (newWW2 != newWW1)
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen!", "Fout wachtwoord");
                    txtNieuwWW.Clear();
                    txtControleWW.Clear();
                }
                else
                {
                    G.Wachtwoord = opgeslagenWW;
                    GebruikersDA.WWVeranderen(G, newWW2);
                    MessageBox.Show("Uw wachtwoord is veranderd.", "");
                    txtWW.Clear();
                    txtNieuwWW.Clear();
                    txtControleWW.Clear();
                    btnOk.Visible = true;
                    btnWWVeranderen.Visible = false;
                    lblWW.Visible = true;
                    lblNieuwWW.Visible = false;
                    lblControleWW.Visible = false;
                    txtWW.Visible = true;
                    txtNieuwWW.Visible = false;
                    txtControleWW.Visible = false;
                }
            }
        }
    }
}
