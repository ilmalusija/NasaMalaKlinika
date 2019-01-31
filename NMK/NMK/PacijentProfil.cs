using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace NMK
{
    public partial class PacijentProfil : Form
    {
        private Klinika klinika;
        private Int64 maticniBroj;
        private List<String> pregledi;
        private Image profilna;
        private Int32 racun;
        private Boolean gotovinskoPlacanje;

        public Klinika Klinika { get => klinika; set => klinika = value; }
        public long MaticniBroj { get => maticniBroj; set => maticniBroj = value; }
        public List<string> Pregledi { get => pregledi; set => pregledi = value; }
        public Image Profilna { get => profilna; set => profilna = value; }
        public int Racun { get => racun; set => racun = value; }
        public bool GotovinskoPlacanje { get => gotovinskoPlacanje; set => gotovinskoPlacanje = value; }

        public PacijentProfil(Klinika k, long maticni)
        {
            InitializeComponent();
            Klinika = k;
            MaticniBroj = maticni;
            Pregledi = new List<string>();
            Racun = 0;
            GotovinskoPlacanje = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PacijentProfil_Load(object sender, EventArgs e)
        {
            Pacijent P = Klinika.DajPacijenta(MaticniBroj);
            pictureBox1.Image = P.Profilna;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void richTextBox1_ReadOnlyChanged(object sender, EventArgs e)
        {
            
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Pacijent P = Klinika.DajPacijenta(MaticniBroj);
            if (e.Node.Name.Equals("osnovni podaci"))
            {
                richTextBox1.Text = "\n";
                if (P.Ime.Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.Ime;
                richTextBox1.Text += "\n";
                if (P.Prezime.Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.Prezime;
                richTextBox1.Text += "\n";
                if (P.DatumRodjenja.ToString().Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.DatumRodjenja.ToString();
                richTextBox1.Text += "\n";
                if (P.MaticniBroj.ToString().Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.MaticniBroj.ToString();
                richTextBox1.Text += "\n\n";
                if (P.Pol.Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.Pol;
                richTextBox1.Text += "\n";
                if (P.AdresaStanovanja.Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.AdresaStanovanja;
                richTextBox1.Text += "\n";
                if (P.BracnoStanje.Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.BracnoStanje;
                richTextBox1.Text += "\n";
                if (P.Lozinka.Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.Lozinka;
                richTextBox1.Text += "\n";
                if (P.DatumPrijave.ToString().Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.DatumPrijave.ToString();
                richTextBox1.Text += "\n";

            }
            if (e.Node.Name.Equals("podaci iz kartona"))
            {
                richTextBox1.Text += "\n\n";
                if (P.SadasnjaBolest.Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.SadasnjaBolest;
                richTextBox1.Text += "\n";
                if (P.SadasnjaAlergija.Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.SadasnjaAlergija;
                richTextBox1.Text += "\n";
                richTextBox1.Text += "";
                if (P.RanijeBolesti.Count == 0) richTextBox1.Text += "-";
                else
                {
                    foreach (String bolest in P.RanijeBolesti)
                    {
                        richTextBox1.Text += bolest;
                        richTextBox1.Text += " ";
                    }
                }
                richTextBox1.Text += "\n";
                richTextBox1.Text += "";
                if (P.RanijeAlergije.Count == 0) richTextBox1.Text += "-";
                else
                {
                    foreach (String alergija in P.RanijeAlergije)
                    {
                        richTextBox1.Text += alergija;
                        richTextBox1.Text += " ";
                    }
                }
                richTextBox1.Text += "\n\n";
                richTextBox1.Text += "";
                if (P.Terapije.Count == 0) richTextBox1.Text += "-";
                else
                {
                    foreach (String terapija in P.Terapije)
                    {
                        richTextBox1.Text += terapija;
                        richTextBox1.Text += " ";
                    }
                }
                richTextBox1.Text += "\n";
                richTextBox1.Text += "";
                if (P.ZakljucakDoktora.Count == 0) richTextBox1.Text += "-";
                else
                {
                    foreach (String z in P.ZakljucakDoktora)
                    {
                        richTextBox1.Text += z;
                        richTextBox1.Text += " ";
                    }
                }
                richTextBox1.Text += "\n";
                richTextBox1.Text += "";
                if (P.Pregledi.Count == 0) richTextBox1.Text += "-";
                else
                {
                    foreach (String p in P.Pregledi)
                    {
                        richTextBox1.Text += p;
                        richTextBox1.Text += " ";
                    }
                }
                richTextBox1.Text += "\n";
                if (P.Vakcinacije.Equals("")) richTextBox1.Text += "-"; else richTextBox1.Text += P.Vakcinacije;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nazadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PacijentPrijava1 pp = new PacijentPrijava1(Klinika);
            pp.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Pregledi.Add(checkBox1.Text);
                Racun += Ordinacija.CIJENA_PREGLEDA1;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Pregledi.Add(checkBox2.Text);
                Racun += Ordinacija.CIJENA_PREGLEDA1;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Pregledi.Add(checkBox3.Text);
                Racun += Ordinacija.CIJENA_PREGLEDA1;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                Pregledi.Add(checkBox6.Text);
                Racun += Ordinacija.CIJENA_PREGLEDA1;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                Pregledi.Add(checkBox7.Text);
                Racun += Ordinacija.CIJENA_PREGLEDA1;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                Pregledi.Add(checkBox8.Text);
                Racun += Ordinacija.CIJENA_PREGLEDA1;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Pregledi.Add(checkBox4.Text);
                Racun += Ordinacija.CIJENA_PREGLEDA1;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                Pregledi.Add(checkBox5.Text);
                Racun += Ordinacija.CIJENA_PREGLEDA1;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                Pregledi.Add(checkBox9.Text);
                Racun += Ordinacija.CIJENA_PREGLEDA1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox7.Checked || checkBox8.Checked || checkBox9.Checked)
            {
                toolStripStatusLabel1.Visible = false;
                Pacijent P = Klinika.DajPacijenta(MaticniBroj);
                P.NapraviRasporedPregleda(Pregledi);
                foreach (String pregled in Pregledi) Klinika.DajOrdinaciju(pregled).PovecajRedCekanja();
                MessageBox.Show("Raspored pregleda uspješno kreiran!");
            }
            else
            {
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.Text = "Morate odabrati bar jedan pregled";
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pacijent P = Klinika.DajPacijenta(MaticniBroj);
            if (P.RasporedPregleda.Count == 0) richTextBox1.Text = "Raspored još nije kreiran";
            else
            {
                richTextBox2.Text = "";
                foreach (String pregled in Pregledi)
                {
                    richTextBox2.Text += pregled;
                    richTextBox2.Text += " pregled";
                    richTextBox2.Text += "\n";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "";
            foreach (Ordinacija ordinacija in Klinika.Ordinacije)
            {
                richTextBox3.Text += ordinacija.TipPregleda;
                richTextBox3.Text += " pregled ";
                richTextBox3.Text += ordinacija.RedCekanja.ToString();
                richTextBox3.Text += "\n";
            }
        }

        private void richTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = "";
            foreach(String pregled in Klinika.DajPacijenta(MaticniBroj).RasporedPregleda)
            {
                richTextBox4.Text += pregled;
                richTextBox4.Text += " ";
                richTextBox4.Text += Ordinacija.CIJENA_PREGLEDA1.ToString();
                richTextBox4.Text += "\n";
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pacijent P = Klinika.DajPacijenta(MaticniBroj);
            P.Dug = Racun;
            label3.Text = P.IspostaviRacun(GotovinskoPlacanje).ToString();
            label7.Text = (P.IspostaviRacun(GotovinskoPlacanje) / 12).ToString();
            label3.Visible = true;
            if (!GotovinskoPlacanje)
            {
                label6.Visible = true;
                label7.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) GotovinskoPlacanje = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) GotovinskoPlacanje = false;
        }
    }
}
