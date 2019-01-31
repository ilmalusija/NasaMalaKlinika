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
    public partial class Administrator : Form
    {
        private Klinika klinika;
        private String korisnickoImeD;
        private String korisnickoImeT;
        private Int64 jmbg;

        public Administrator(Klinika k)
        {
            InitializeComponent();
            Klinika = k;
        }

        public Klinika Klinika { get => klinika; set => klinika = value; }
        public string KorisnickoImeD { get => korisnickoImeD; set => korisnickoImeD = value; }
        public string KorisnickoImeT { get => korisnickoImeT; set => korisnickoImeT = value; }
        public long Jmbg { get => jmbg; set => jmbg = value; }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            KorisnickoImeD = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Jmbg = Int64.Parse(textBox4.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            KorisnickoImeT = textBox6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Visible = false;
                Klinika.ObrisiDoktora(KorisnickoImeD);
                MessageBox.Show("Doktor uspješno obrisan!");
            }
            catch(ArgumentOutOfRangeException)
            {
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.Text = "Ne postoji doktor s tim korisničkim imenom!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel2.Visible = false;
                Klinika.ObrisiPacijenta(Jmbg);
                MessageBox.Show("Pacijent uspješno obrisan!");
            }
            catch (ArgumentOutOfRangeException)
            {
                toolStripStatusLabel2.Visible = true;
                toolStripStatusLabel2.Text = "Ne postoji pacijent s tim korisničkim imenom!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel3.Visible = false;
                Klinika.ObrisiTehnicara(KorisnickoImeT);
                MessageBox.Show("Tehnicar uspjesno obrisan!");
            }
            catch(ArgumentOutOfRangeException)
            {
                toolStripStatusLabel3.Visible = true;
                toolStripStatusLabel3.Text = "Ne postoji tehničar s tim korisničkim imenom!";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
