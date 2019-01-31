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
    public partial class TehnicarPrijava : Form
    {
        private Klinika klinika;

        public Klinika Klinika { get => klinika; set => klinika = value; }

        public TehnicarPrijava(Klinika k)
        {
            InitializeComponent();
            Klinika = k;
        }

        private void TehnicarPrijava_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            TehnicarPrijava1 tP = new TehnicarPrijava1(Klinika);
            tP.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TehnicarRegistracija1 tR = new TehnicarRegistracija1(Klinika);
            tR.Show();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(Klinika);
            f1.Show();
        }
    }
}
