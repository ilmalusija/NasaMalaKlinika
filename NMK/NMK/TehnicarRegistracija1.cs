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
    public partial class TehnicarRegistracija1 : Form
    {
        private String imeIPrezime;
        private String korisnickoIme;
        private String lozinka;
        private Klinika klinika;
        private Boolean eIP = false, eKI = false, eP = false, ePP = false;

        public TehnicarRegistracija1(Klinika k)
        {
            InitializeComponent();
            Klinika = k;
        }

        public string ImeIPrezime { get => imeIPrezime; set => imeIPrezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public Klinika Klinika { get => klinika; set => klinika = value; }

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
     
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(eIP || eKI || eP || ePP))
            {
                Tehnicar T = new Tehnicar();
                T.RegistrujTehnicara(ImeIPrezime, KorisnickoIme, Lozinka);
                Klinika.DodajTehnicara(T);
                MessageBox.Show("Medicinski tehničar " + ImeIPrezime + " uspješno registrovan!");
                Form1 F = new Form1(Klinika);
                this.Hide();
                F.Show();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                epKorisnickoIme.SetError(textBox1, " Polje korisničko ime mora biti popunjeno!");
                eKI = true;
            }
            else if (textBox1.Text.Length < 6)
            {
                epKorisnickoIme.SetError(textBox1, " Korisničko ime mora imati najmanje 6 karaktera!");
                eKI = true;
            }
            else
            {
                epKorisnickoIme.Dispose();
                eKI = false;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                epPassword.SetError(textBox2, " Polje password mora biti popunjeno!");
                eP = true;
            }
            else if (textBox2.Text.Length < 6)
            {
                epPassword.SetError(textBox2, " Password mora imati najmanje 8 karaktera!");
                eP = true;
            }
            else
            {
                epPassword.Dispose();
                eP = false;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox2.Text)
            {
                epPotvrdaPassworda.SetError(textBox3, " Passwordi nisu jednaki!");
                ePP = true;
            }
            else
            {
                epPotvrdaPassworda.Dispose();
                ePP = false;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            Lozinka = textBox2.Text;
        }

        private void TehnicarRegistracija1_Load(object sender, EventArgs e)
        {

        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1(Klinika);
            f.Show();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                epImePrezime.SetError(textBox4, " Polje ime i prezime mora biti popunjeno!");
                eIP = true;
            }
            else
            {
                epImePrezime.Dispose();
                eIP = false;
            }
        }
    }
}
