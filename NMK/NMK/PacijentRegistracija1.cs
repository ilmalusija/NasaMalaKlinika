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
    public partial class PacijentRegistracija1 : Form
    {
        private Klinika klinika;
        private String ime;
        private String prezime;
        private String lozinka;
        private DateTime datumRodjenja;
        private String pol;
        private String bracnoStanje;
        private String adresa;
        private Int64 maticniBroj;
        private DateTime datumPrijema;
        private DateTime datumSlike;
        private Boolean ozenjen = false, neozenjen = false, slika = false;
        private Boolean eI = false, ePr = false, eDR = false, eMB = false, eA = false, eBS = false, ePas = false, ePPas = false, eDP = false, eSS = false;


        public PacijentRegistracija1(Klinika k)
        {
            InitializeComponent();
            Klinika = k;
        }

        public Klinika Klinika { get => klinika; set => klinika = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Pol { get => pol; set => pol = value; }
        public string BracnoStanje { get => bracnoStanje; set => bracnoStanje = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public long MaticniBroj { get => maticniBroj; set => maticniBroj = value; }
        public DateTime DatumPrijema { get => datumPrijema; set => datumPrijema = value; }
        public DateTime DatumSlike { get => datumSlike; set => datumSlike = value; }

        private void PacijentRegistracija1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Ime = textBox4.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Prezime = textBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DatumRodjenja = Convert.ToDateTime(dateTimePicker1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MaticniBroj = Int64.Parse(textBox3.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Pol = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Pol = radioButton2.Text;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Adresa = textBox5.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Lozinka = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                epAdresa.SetError(textBox5, " Polje adresa mora biti popunjeno!");
                eA = true;
            }
            else
            {
                epAdresa.Dispose();
                eA = false;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                epPassword.SetError(textBox7, " Polje password mora biti popunjeno!");
                ePas = true;
            }
            else
            {
                epPassword.Dispose();
                ePas = false;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text != textBox8.Text) 
            {
                epPotvrdaPassworda.SetError(textBox8, " Passwordi nisu jednaki!");
                ePPas = true;
            }
            else
            {
                epPotvrdaPassworda.Dispose();
                ePPas = false;
            }
        }

        private void dateTimePicker2_Leave(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker3_Leave(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                epPrezime.SetError(textBox1, " Polje prezime mora biti popunjeno!");
                ePr = true;
            }
            else
            {
                epPrezime.Dispose();
                ePr = false;
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                epMaticniBroj.SetError(textBox3, " Polje matični broj mora biti popunjeno");
                eMB = true;
            }
            else if (textBox3.Text.Length < 13)
            {
                epMaticniBroj.SetError(textBox3, " Matični broj mora imati 13 karaktera!");
                eMB = true;
            }
            else
            {
                epMaticniBroj.Dispose();
                eMB = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(ozenjen || neozenjen))
            {
                epBracnoStanje.SetError(radioButton4, "Morate odabrati bračno stanje!");
                eBS = true;
            }
            else
            {
                epBracnoStanje.Dispose();
                eBS = false;
            }
            if (Convert.ToDateTime(dateTimePicker1.Text) == DateTime.Today)
            {
                epDatumRodjenja.SetError(dateTimePicker1, " Morate odabrati datum rođenja!");
                eDR = true;
            }
            else
            {
                epDatumRodjenja.Dispose();
                eDR = false;
            }
            if (slika)
            {
                if (((DateTime.Today.Year - Convert.ToDateTime(dateTimePicker3.Text).Year) * 12) + DateTime.Today.Month - Convert.ToDateTime(dateTimePicker3.Text).Month > 6)
                {
                    epSlikaUslikana.SetError(dateTimePicker3, " Slika ne smije biti starija od 6 mjeseci!");
                    eSS = true;
                }
                else
                {
                    epSlikaUslikana.Dispose();
                    eSS = false;
                }
            }
            if (!(eI || ePr || eDR || eMB || eA || eBS || ePas || ePPas || eDP || eSS))
            {
                Pacijent P = new Pacijent();
                P.RegistrujPacijenta(Ime, Prezime, Lozinka, DatumRodjenja, MaticniBroj, Pol, Adresa, BracnoStanje, DatumPrijema);
                P.Profilna = pictureBox1.Image;
                P.DatumSlike = DatumSlike;
                Klinika.DodajPacijenta(P);
                MessageBox.Show("Pacijent " + Ime + " " + Prezime + " uspješno registrovan!");
                Form1 F = new Form1(Klinika);
                this.Hide();
                F.Show();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            DatumPrijema = Convert.ToDateTime(dateTimePicker1.Text);
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                BracnoStanje = radioButton3.Text;
                ozenjen = true;
                neozenjen = false;
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                BracnoStanje = radioButton4.Text;
                neozenjen = true;
                ozenjen = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpeg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
            dialog.ShowDialog();
            imageLocation = dialog.FileName;
            pictureBox1.ImageLocation = imageLocation;
            slika = true; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            PacijentPrijava pp = new PacijentPrijava(Klinika);
            pp.Show();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DatumSlike = Convert.ToDateTime(dateTimePicker3.Text);

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                epIme.SetError(textBox4, " Polje ime mora biti popunjeno!");
                eI = true;
            }
            else
            {
                epIme.Dispose();
                eI = false;
            }
        }
    }
}
