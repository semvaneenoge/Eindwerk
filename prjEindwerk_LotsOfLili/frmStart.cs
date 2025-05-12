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

            // Voert methodes uit
            // Tags instellen
            setTags(grbLogin);
            setTags(grbRegistreer);

            // Reset instellen aan controls
            ResetToevoegen(grbLogin);
            ResetToevoegen(grbRegistreer);
        }

        private void setTags(Control control)
        {
            // Geeft overeenkomende textboxen een Tag
            foreach (Control item in control.Controls)
            {
                if (item is TextBox txt)
                {
                    txt.Tag = txt.Text;
                }
            }
        }

        // Textboxen leegmaken + terug vullen
        private void Reset(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            bool password = txt.Name.Contains("WW");

            // Controle op focus van textbox
            if (txt.Focused)
            {
                //Textbox leegmaken of password character instellen
                if (txt.Text == txt.Tag.ToString())
                {
                    txt.Clear();
                }

                if (password)
                {
                    txt.PasswordChar = '*';
                }
            }
            else
            {
                // Textbox terug vullen of password character instellen
                if (string.IsNullOrEmpty(txt.Text))
                {
                    txt.Text = txt.Tag.ToString();

                    if (password)
                    {
                        txt.PasswordChar = '\0';
                    }
                }
                else
                {
                    if (password)
                    {
                        txt.PasswordChar = '*';
                    }
                }
            }
        }

        private void ResetToevoegen(Control control)
        {
            // Geeft Reset() door aan overeenkomende textboxen
            foreach (Control item in control.Controls)
            {
                if (item is TextBox txt && txt.Tag != null)
                {
                    txt.Enter += Reset;
                    txt.Leave += Reset;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Login
            Gebruikers G = new Gebruikers();

            bool isAdmin;

            // Gegevens invullen
            G.Email = txtEmailInlog.Text;
            G.Wachtwoord = txtWWInlog.Text;

            bool blnLogin = GebruikersDA.LoginValidation(G, out isAdmin, out customerName);

            // Controle op juiste inloggegevens
            if (blnLogin == true)
            {
                // Gegevens doorgeven en Home openenen
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

            string controlePost = txtPostcode.Text.Trim();
            string controleTel1 = txtTelefoon.Text.Replace(" ", "");

            bool controleTel2;

            if (controleTel1.StartsWith("+"))
            {
                controleTel2 = controleTel1.Substring(1).All(char.IsDigit);
            }
            else
            {
                controleTel2 = controleTel1.All(char.IsDigit);
            }

            // Controle op default tekst en getallen
            if (txtVoornaam.Text != txtVoornaam.Tag.ToString())
            {
                if (txtNaam.Text != txtNaam.Tag.ToString())
                {
                    if (txtAdres.Text != txtAdres.Tag.ToString())
                    {
                        if (controlePost.All(char.IsDigit))
                        {
                            if (controleTel2)
                            {
                                if (txtEmailRegistreer.Text != txtEmailRegistreer.Tag.ToString())
                                {
                                    if (txtHerhaalWW.Text == txtWWRegistreer.Text)
                                    {
                                        G.Voornaam = txtVoornaam.Text;
                                        G.Naam = txtNaam.Text;
                                        G.Adres = txtAdres.Text;
                                        G.Postcode = Convert.ToInt32(txtPostcode.Text);
                                        G.Telefoon = txtTelefoon.Text;
                                        G.Email = txtEmailRegistreer.Text;
                                        G.Wachtwoord = txtWWRegistreer.Text;

                                        GebruikersDA.Registreren(G, out customerName);

                                        // Controle op lege naam
                                        if (string.IsNullOrEmpty(customerName))
                                        {
                                            // Vroeg stoppen, zal volgende code niet uitvoeren
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
                                        MessageBox.Show("Wachtwoorden komen niet overeen.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Gelieve een getal in te vullen", "Telefoon");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Gelieve een getal in te vullen", "Postcode");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gelieve een adres in te vullen", "Adres");
                    }
                }
                else
                {
                    MessageBox.Show("Gelieve een naam in te vullen", "Naam");
                }
            }
            else
            {
                MessageBox.Show("Gelieve een voornaam in te vullen", "Voornaam");
            }            
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            // Login tonen
            grbRegistreer.Visible = false;
            this.Height = 460;
        }
    }
}
