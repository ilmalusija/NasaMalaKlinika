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
    public partial class TehnicarPrijava1 : Form
    {
        private Klinika klinika;
        private String lozinka;
        private String korisnickoIme;

        public TehnicarPrijava1(Klinika k)
        {
            InitializeComponent();
            Klinika = k;
        }

        public Klinika Klinika { get => klinika; set => klinika = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }

        private void TehnicarPrijava1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            KorisnickoIme = textBox2.Text;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tehnicar T = Klinika.DajTehnicara(KorisnickoIme);
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
                    TehnicarPosao tp = new TehnicarPosao(Klinika, KorisnickoIme);
                    tp.Show();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Tehničar s tim korisničkim imenom ne postoji";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TehnicarPrijava tp = new TehnicarPrijava(Klinika);
            tp.Show();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Equals("Korisničko ime"))
            {
                ispisGreske.Visible = true;
                ispisGreske.ForeColor = Color.Red;
                ispisGreske.Text = "Unesite Vaše korisničko ime";
            }
            try
            {
                Klinika.DajTehnicara(KorisnickoIme);
            }
            catch(ArgumentOutOfRangeException)
            {
                ispisGreske.Visible = true;
                ispisGreske.ForeColor = Color.Red;
                ispisGreske.Text = "Tehničar s tim korisničkim imenom ne postoji";
            }

        }
    }
}
