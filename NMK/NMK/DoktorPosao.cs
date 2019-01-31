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
    public partial class DoktorPosao : Form
    {
        private Klinika klinika;
        private Pacijent pacijent;
        private Int64 maticniBroj;
        private String bolest;
        private String alergija;
        private String zakljucak;
        private String terapija;
        private String pregled;
        private DateTime vrijemePregleda;
        private String garancija;
        private String vakcinacije;
        private String korisnickoIme;
        private String novaLozinka;
        private Boolean jmbg = false, jmbg1 = false, eP = false, ePP = false, neispravna = false;

        public DoktorPosao(Klinika k, string ki)
        {
            InitializeComponent();
            Klinika = k;
            KorisnickoIme = ki;
        }

        public Klinika Klinika { get => klinika; set => klinika = value; }
        public Pacijent Pacijent { get => pacijent; set => pacijent = value; }
        public long MaticniBroj { get => maticniBroj; set => maticniBroj = value; }
        public string Bolest { get => bolest; set => bolest = value; }
        public string Alergija { get => alergija; set => alergija = value; }
        public string Zakljucak { get => zakljucak; set => zakljucak = value; }
        public string Terapija { get => terapija; set => terapija = value; }
        public string Pregled { get => pregled; set => pregled = value; }
        public DateTime VrijemePregleda { get => vrijemePregleda; set => vrijemePregleda = value; }
        public string Garancija { get => garancija; set => garancija = value; }
        public string Vakcinacije { get => vakcinacije; set => vakcinacije = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string NovaLozinka { get => novaLozinka; set => novaLozinka = value; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MaticniBroj = Int64.Parse(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pregled = comboBox1.SelectedItem.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            VrijemePregleda = DateTime.Parse(dateTimePicker1.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Garancija = textBox7.Text;
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
            Terapija = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Zakljucak = textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Visible = false;
                Pacijent P = Klinika.DajPacijenta(MaticniBroj);
                if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox8.Text))
                {
                    toolStripStatusLabel1.Visible = true;
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    toolStripStatusLabel1.Text = "Morate ispuniti sva polja";
                }
                else if (jmbg)
                {
                    toolStripStatusLabel1.Visible = true;
                    toolStripStatusLabel1.ForeColor = Color.Red;
                    toolStripStatusLabel1.Text = "Pacijent s tim JMBG ne postoji!";
                }
                else if (!jmbg && !(string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox8.Text)))
                {
                    toolStripStatusLabel1.Visible = false;
                    P.AzurirajKarton(Bolest, Alergija, Terapija, Vakcinacije, Zakljucak);
                    MessageBox.Show("Karton uspješno ažuriran!");
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "Pacijent s tim JMBG ne postoji!";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel2.Visible = false;
                Pacijent P = Klinika.DajPacijenta(Int64.Parse(textBox6.Text));
                if (textBox7.Text == "" || comboBox1.Text == "Pregledi...")
                {
                    toolStripStatusLabel2.Visible = true;
                    toolStripStatusLabel2.Text = "Morate ispuniti sva polja";
                    toolStripStatusLabel2.ForeColor = Color.Red;
                }
                else if (jmbg1)
                {
                    toolStripStatusLabel2.Visible = true;
                    toolStripStatusLabel2.Text = "Pacijent s tim JMBG ne postoji!";
                    toolStripStatusLabel2.ForeColor = Color.Red;
                }
                else if (!jmbg && !(textBox7.Text == "" || comboBox1.Text == "Pregledi..."))
                {
                    toolStripStatusLabel2.Visible = false;
                    Klinika.DajOrdinaciju(pregled).SmanjiRedCekanja();
                    P.EvidentirajPregled(Pregled, VrijemePregleda, Garancija);
                    MessageBox.Show("Pregled uspješno evidentiran!");
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                toolStripStatusLabel2.Visible = true;
                toolStripStatusLabel2.Text = "Pacijent s tim JMBG ne postoji!";
                toolStripStatusLabel2.ForeColor = Color.Red;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Vakcinacije = textBox8.Text;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoktorPrijava1 dp1 = new DoktorPrijava1(Klinika);
            this.Hide();
            dp1.Show();
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Doktor D = Klinika.DajDoktora(KorisnickoIme);
            //provjeriti staru lozinku
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text.Equals(textBox11.Text)) NovaLozinka = textBox11.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!(eP || ePP || neispravna))
            {
                Doktor D = Klinika.DajDoktora(KorisnickoIme);
                D.Lozinka = NovaLozinka;
                MessageBox.Show("Lozinka izmijenjena!");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                Pacijent P = Klinika.DajPacijenta(Int64.Parse(textBox1.Text));
                epJMBG.Dispose();
                jmbg = false;
            }
            catch(ArgumentOutOfRangeException)
            {
                epJMBG.SetError(textBox1, "Pacijent s tim JMBG ne postoji!");
                jmbg = true;
            }
        }

        private void DoktorPosao_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            MaticniBroj = Int64.Parse(textBox6.Text);
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox9_Leave(object sender, EventArgs e)
        {
            Doktor D = Klinika.DajDoktora(KorisnickoIme);
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

        private void textBox6_Leave(object sender, EventArgs e)
        {
            try
            {
                Pacijent P = Klinika.DajPacijenta(Int64.Parse(textBox6.Text));
                epJMBG1.Dispose();
                jmbg1 = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                epJMBG1.SetError(textBox6, "Pacijent s tim JMBG ne postoji!");
                jmbg1 = true;
            }
        }
    }
}
