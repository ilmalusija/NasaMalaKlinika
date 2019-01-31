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
    public partial class TehnicarPosao : Form
    {
        private Klinika klinika;
        private Int64 maticniBroj;
        private String bolest;
        private String alergija;
        private String ranijeAlergije;
        private String ranijeBolesti;
        private String vakcinacije;
        private String korisnickoIme;
        private String novaLozinka;
        private Boolean jmbg = false, neispravna = false, eP = false, ePP = false;
     
        public TehnicarPosao(Klinika k, string ki)
        {
            InitializeComponent();
            Klinika = k;
            KorisnickoIme = ki;
        }

        public Klinika Klinika { get => klinika; set => klinika = value; }
        public long MaticniBroj { get => maticniBroj; set => maticniBroj = value; }
        public string Bolest { get => bolest; set => bolest = value; }
        public string Alergija { get => alergija; set => alergija = value; }
        public string RanijeAlergije { get => ranijeAlergije; set => ranijeAlergije = value; }
        public string RanijeBolesti { get => ranijeBolesti; set => ranijeBolesti = value; }
        public string Vakcinacije { get => vakcinacije; set => vakcinacije = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string NovaLozinka { get => novaLozinka; set => novaLozinka = value; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MaticniBroj = Int64.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Bolest = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Alergija = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Vakcinacije = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            RanijeBolesti = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            RanijeAlergije = textBox6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Visible = false;
                Pacijent P = Klinika.DajPacijenta(MaticniBroj);
                if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox4.Text))
                {
                    toolStripStatusLabel1.Visible = true;
                    toolStripStatusLabel1.Text = "Polja sadašnja bolest i vakcinacije moraju biti ispunjena";
                    toolStripStatusLabel1.ForeColor = Color.Red;
                }
                else if (jmbg)
                {
                    toolStripStatusLabel1.Visible = true;
                    toolStripStatusLabel1.Text = "Ne postoji pacijent s tim JMBG!";
                    toolStripStatusLabel1.ForeColor = Color.Red;
                }
                else if (!jmbg && !(string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox4.Text)))
                {
                    P.PopuniElektronskiKarton(Bolest, Alergija, Vakcinacije, RanijeBolesti, RanijeAlergije);
                    MessageBox.Show("Kreiran karton pacijenta " + Klinika.DajPacijenta(MaticniBroj).Ime + " " + Klinika.DajPacijenta(MaticniBroj).Prezime + "!");
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.Text = "Ne postoji pacijent s tim JMBG!";
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }

        private void TehnicarPosao_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TehnicarPrijava1 tp = new TehnicarPrijava1(Klinika);
            tp.Show();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Tehnicar T = Klinika.DajTehnicara(KorisnickoIme);
            //provjeriti staru lozinku
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach (Ordinacija ordinacija in Klinika.Ordinacije)
            {
                richTextBox1.Text += ordinacija.TipPregleda;
                richTextBox1.Text += " pregled ";
                richTextBox1.Text += ordinacija.RedCekanja.ToString();
                richTextBox1.Text += "\n";
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text != textBox11.Text)
            {
                epPotvrdaPassworda.SetError(textBox11, " Passwordi nisu jednaki!");
                ePP = true;
            }
            else
            {
                epPotvrdaPassworda.Dispose();
                ePP = false;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!(eP || ePP || neispravna))
            {
                Tehnicar D = Klinika.DajTehnicara(KorisnickoIme);
                D.Lozinka = NovaLozinka;
                MessageBox.Show("Lozinka izmijenjena!");
            }
        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox10.Text.Equals(textBox11.Text)) NovaLozinka = textBox11.Text;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                Pacijent P = Klinika.DajPacijenta(Int64.Parse(textBox1.Text));
                epJMBG.Dispose();
                jmbg = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                epJMBG.SetError(textBox1, "Pacijent s tim JMBG ne postoji!");
                jmbg = true;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox10.Text) || textBox10.Text.Length < 6)
            {
                epPassword.SetError(textBox10, " Password mora imati najmanje 8 karaktera!");
                eP = true;
            }
            else
            {
                epPassword.Dispose();
                eP = false;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            Tehnicar D = Klinika.DajTehnicara(KorisnickoIme);
            if (D.CalculateMD5Hash(textBox9.Text) != D.Lozinka)
            {
                toolStripStatusLabel3.Visible = true;
                toolStripStatusLabel3.Text = "Neispravna lozinka";
                toolStripStatusLabel3.ForeColor = Color.Red;
                neispravna = true;
            }
            else
            {
                toolStripStatusLabel3.Visible = false;
                neispravna = false;
            }
        }
    }
}
