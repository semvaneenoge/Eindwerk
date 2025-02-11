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
        public frmStart()
        {
            InitializeComponent();

            txtEmailInlog.Tag = txtEmailInlog.Text;
            txtWWInlog.Tag = txtWWInlog.Text;

            txtWWRegistreer.Tag = txtWWRegistreer.Text;
            txtHerhaalWW.Tag = txtHerhaalWW.Text;

            // ---Notes---
            //
            // Registreren controle enkel WW en herhalen, moet meer controle --> error bij enkel WW en herhalen
            //
            // Reset() --> verder uitwerken + PasswordChar
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Login
            Gebruikers G = new Gebruikers();

            bool isAdmin;
            string Naam;

            G.Email = txtEmailInlog.Text;
            G.Wachtwoord = txtWWInlog.Text;

            bool blnLogin = GebruikersDA.LoginValidation(G, out isAdmin, out Naam);

            if (blnLogin == true)
            {
                this.Hide();
                frmHome Dashboard = new frmHome();
                Dashboard.isAdmin = isAdmin;
                Dashboard.Naam = Naam;
                Dashboard.Show();
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

                GebruikersDA.Registreren(G);

                this.Hide();
                frmHome Dashboard = new frmHome();
                Dashboard.Show();
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
