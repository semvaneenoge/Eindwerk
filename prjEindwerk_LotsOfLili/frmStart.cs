using prjEindwerk_LotsOfLili.DA;
using prjEindwerk_LotsOfLili.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEindwerk_LotsOfLili
{
    public partial class frmStart : Form
    {
        public string customerName;
     
        public frmStart()
        {
            InitializeComponent();

            // ---Notes---
            //
            // Meer controle --> tel, post etc. --> nummers
            //
            // Reset() --> verder uitwerken + PasswordChar --> laten werken met tab

            txtEmailInlog.Tag = txtEmailInlog.Text;
            txtWWInlog.Tag = txtWWInlog.Text;

            txtWWRegistreer.Tag = txtWWRegistreer.Text;
            txtHerhaalWW.Tag = txtHerhaalWW.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Login
            Gebruikers G = new Gebruikers();

            bool isAdmin;

            G.Email = txtEmailInlog.Text;
            G.Wachtwoord = txtWWInlog.Text;

            bool blnLogin = GebruikersDA.LoginValidation(G, out isAdmin, out customerName);

            if (blnLogin == true)
            {
                string email = txtEmailInlog.Text.Trim();
                frmHome Home = new frmHome();
                Home.userEmail = email;
                Home.isAdmin = isAdmin;
                Home.customerNameHome = customerName;
                Home.Show();
                this.Hide();
            }
            else
            {
                // Foutmelding
                MessageBox.Show("Gebruikersnaam of wachtwoord is fout.");
            }
        }

        private void btnRegistratie_Click(object sender, EventArgs e)
        {
            // Registratie tonen
            grbRegistreer.Visible = true;
            this.Height = 485;
        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            // Registratie
            Gebruikers G = new Gebruikers();

            if (txtHerhaalWW.Text == txtWWRegistreer.Text)
            {
                G.Voornaam = txtVoornaam.Text;
                G.Naam = txtNaam.Text;
                G.Adres = txtAdres.Text;
                G.Telefoon = txtTelefoon.Text;
                G.Email = txtEmailRegistreer.Text;
                G.Wachtwoord = txtWWRegistreer.Text;

                GebruikersDA.Registreren(G, out customerName);

                if (string.IsNullOrEmpty(customerName))
                {
                    // stopt de rest van de code
                    return;
                }

                this.Hide();
                frmHome Home = new frmHome();
                string email = txtEmailRegistreer.Text;
                Home.userEmail = email;
                Home.customerNameHome = customerName;
                Home.Show();
            }
            else
            {
                // Foutmelding
                MessageBox.Show("Foutieve gegevens.");
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            // Login tonen
            grbRegistreer.Visible = false;
            this.Height = 460;
        }


        // Textboxen leegmaken + terug vullen
        
        private void Reset(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt.Focused)
            {
                if (txt.Text == txt.Tag.ToString())
                {
                    txt.Clear();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    txt.Text = txt.Tag.ToString();
                }
            }
        }

        private void txtEmailInlog_Enter(object sender, EventArgs e)
        {
            Reset(sender, e );
        }

        private void txtEmailInlog_Leave(object sender, EventArgs e)
        {
            Reset(sender, e);
        }

        private void txtWWInlog_Enter(object sender, EventArgs e)
        {
            Reset(sender, e);
            txtWWInlog.PasswordChar = '*';
        }

        private void txtWWInlog_Leave(object sender, EventArgs e)
        {
            Reset(sender, e);
            if (txtWWInlog.Text == "" || txtWWInlog.Text == txtWWInlog.Tag.ToString())
            {
                txtWWInlog.PasswordChar = '\0';
            }
        }

        private void txtWWRegistreer_Enter(object sender, EventArgs e)
        {
            Reset(sender, e);
        }

        private void txtWWRegistreer_Leave(object sender, EventArgs e)
        {
            Reset(sender, e);
        }

        private void txtHerhaalWW_Enter(object sender, EventArgs e)
        {
            Reset(sender, e);
        }

        private void txtHerhaalWW_Leave(object sender, EventArgs e)
        {
            Reset(sender, e);
        }
    }
}
