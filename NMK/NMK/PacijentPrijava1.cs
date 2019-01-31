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
    public partial class PacijentPrijava1 : Form
    {
        private Klinika klinika;
        private Int64 maticniBroj;
        private String lozinka;

        public Klinika Klinika { get => klinika; set => klinika = value; }
        public long MaticniBroj { get => maticniBroj; set => maticniBroj = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }

        public PacijentPrijava1(Klinika k)
        {
            InitializeComponent();
            Klinika = k;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MaticniBroj = Int64.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pacijent P = Klinika.DajPacijenta(MaticniBroj);
                toolStripStatusLabel1.Visible = false;
                if (P.Lozinka != textBox3.Text)
                {
                    toolStripStatusLabel1.Visible = true;
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    toolStripStatusLabel1.Text = "Neispravna lozinka";
                }
                else
                {
                    toolStripStatusLabel1.Visible = false;
                    this.Close();
                    PacijentProfil pp = new PacijentProfil(Klinika, MaticniBroj);
                    pp.Show();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Pacijent s tim JMBG ne postoji";
            }
            catch(FormatException)
            {
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Pacijent s tim JMBG ne postoji";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PacijentPrijava1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PacijentPrijava pp = new PacijentPrijava(Klinika);
            pp.Show();
        }
    }
}
