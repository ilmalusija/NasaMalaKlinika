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
    public partial class Form1 : Form
    {
        private Klinika klinika;

        public Klinika Klinika { get => klinika; set => klinika = value; }

        public Form1(Klinika k)
        {
            InitializeComponent();
            Klinika = k;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Today.ToString("D");
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.FloralWhite, new Rectangle(245, 100, 100, 100));
            e.Graphics.FillRectangle(Brushes.FloralWhite, 280, 100, 30, 100);
            e.Graphics.FillRectangle(Brushes.FloralWhite, 245, 135, 100, 30);
            e.Graphics.DrawImage(Properties.Resources.HeartBeat, 245, 135, 100, 30);
        }

        private void porukaDobrodoslice_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (izborPrijave.SelectedItem.ToString().Equals("Doktor"))
            {
                this.Hide();
                DoktorPrijava dP = new DoktorPrijava(Klinika);
                dP.Show();
            }
            else if (izborPrijave.SelectedItem.ToString().Equals("Medicinski tehničar"))
            {
                this.Hide();
                TehnicarPrijava tP = new TehnicarPrijava(Klinika);
                tP.Show();
            }
            else if (izborPrijave.SelectedItem.ToString().Equals("Pacijent"))
            {
                this.Hide();
                PacijentPrijava pP = new PacijentPrijava(Klinika);
                pP.Show();
            }
            else
            {
                this.Hide();
                Administrator A = new Administrator(Klinika);
                A.Show();
            }
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naša Mala Klinika je ustanova u kojoj trenutno možete obaviti ordopedski, kardiološki, opšti, oftamološti, otorinolaringološki, laborantski, stomatološki, dermatološki, te internistički pregled. Pristupate našem informacionom sistemu odabirući svoju ulogu: pacijent, doktor, tehničar ili administrator. Klikom na dugme izlaz napuštate aplikaciju."); 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void analitičkiPodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void analitičkiPodaciToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Analiza A = new Analiza(Klinika);
            this.Hide();
            A.Show();
        }
    }
}
