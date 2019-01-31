using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMK
{
    public partial class DoktorRegistracija1 : Form
    {
        private String imeIPrezime;
        private String korisnickoIme;
        private String lozinka;
        private String specijalizacija;
        private Klinika klinika;
        private Boolean eIP = false, eKI = false, eP = false, ePP = false, eS = false;

        public DoktorRegistracija1(Klinika k)
        {
            InitializeComponent();
            Klinika = k;
        }

        public string ImeIPrezime { get => imeIPrezime; set => imeIPrezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string Specijalizacija { get => specijalizacija; set => specijalizacija = value; }
        public Klinika Klinika { get => klinika; set => klinika = value; }

        private void DoktorRegistracija1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ImeIPrezime = textBox4.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            KorisnickoIme = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Lozinka = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Specijalizacija = comboBox1.SelectedItem.ToString();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

                Doktor D = Klinika.DajDoktora(textBox1.Text);
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    eKorisnickoIme.SetError(textBox1, " Polje korisničko ime mora biti popunjeno!");
                    eKI = true;
                }
                else if (textBox1.Text.Length < 6)
                {
                    eKorisnickoIme.SetError(textBox1, " Korisničko ime mora imati najmanje 6 karaktera!");
                    eKI = true;
                }
                else 
                {
                    eKorisnickoIme.Dispose();
                    eKI = false;
                }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                ePassword.SetError(textBox2, " Polje password mora biti popunjeno!");
                eP = true;
            }
            else if (textBox2.Text.Length < 6)
            {
                ePassword.SetError(textBox2, " Password mora imati najmanje 8 karaktera!");
                eP = true;
            }
            else
            {
                ePassword.Dispose();
                eP = false;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox2.Text)
            {
                ePotvrdaPassworda.SetError(textBox3, " Passwordi nisu jednaki!");
                ePP = true;
            }
            else
            {
                ePotvrdaPassworda.Dispose();
                ePP = false;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Specijalizacije...")
            {
                eSpecijalizacija.SetError(comboBox1, " Polje specijalizacija mora biti popunjeno!");
                eS = true;
            }
            else
            {
                eSpecijalizacija.Dispose();
                eS = false;
            }
            if (!(eIP || eKI || eP || ePP || eS))
            {
                Doktor D = new Doktor(Specijalizacija);
                D.RegistrujDoktora(ImeIPrezime, KorisnickoIme, Lozinka);
                Klinika.DodajDoktora(D);
                MessageBox.Show("Doktor " + ImeIPrezime + " uspješno registrovan!");
                Form1 F = new Form1(Klinika);
                this.Hide();
                F.Show();
            }
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorPrijava dp = new DoktorPrijava(Klinika);
            dp.Show();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                eImePrezime.SetError(textBox4, " Polje ime i prezime mora biti popunjeno!");
                eIP = true;
            }
            else
            {
                eImePrezime.Dispose();
                eIP = false;
            }
        }
    }
}
