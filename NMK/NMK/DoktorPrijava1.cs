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
    public partial class DoktorPrijava1 : Form
    {
        private String korisnickoIme;
        private String lozinka;
        private Klinika klinika;

        public DoktorPrijava1(Klinika k)
        {
            InitializeComponent();
            Klinika = k;
        }

        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public Klinika Klinika { get => klinika; set => klinika = value; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            KorisnickoIme = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
            Lozinka = textBox3.Text;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Doktor T = Klinika.DajDoktora(KorisnickoIme);
                toolStripStatusLabel1.Visible = false;
                if (T.Lozinka != T.CalculateMD5Hash(textBox3.Text))
                {
                    toolStripStatusLabel1.Visible = true;
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    toolStripStatusLabel1.Text = "Neispravna lozinka";
                }
                else
                {
                    toolStripStatusLabel1.Visible = false;
                    this.Close();
                    DoktorPosao dp = new DoktorPosao(Klinika, KorisnickoIme);
                    dp.Show();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Doktor s tim korisničkim imenom ne postoji";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorPrijava dp = new DoktorPrijava(Klinika);
            dp.Show();
        }

        private void DoktorPrijava1_Load(object sender, EventArgs e)
        {

        }
    }
}
