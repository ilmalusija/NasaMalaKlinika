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
    public partial class DoktorPrijava : Form
    {
        private Klinika klinika;

        public Klinika Klinika { get => klinika; set => klinika = value; }

        public DoktorPrijava(Klinika k)
        {
            InitializeComponent();
            Klinika = k;
        }

        private void DoktorPrijava_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorPrijava1 dP = new DoktorPrijava1(Klinika);
            dP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoktorRegistracija1 dR = new DoktorRegistracija1(Klinika);
            dR.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(Klinika);
            f1.Show();
        }
    }
}
