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
    public partial class Analiza : Form
    {
        Klinika klinika;

        public Analiza(Klinika k)
        {
            InitializeComponent();
            Klinika = k;
        }

        public Klinika Klinika { get => klinika; set => klinika = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Broj pregleda"].Points.AddXY("Stomatolog", Klinika.DajOrdinaciju("Stomatološki").BrojPregleda);
            chart1.Series["Broj pregleda"].Points.AddXY("Internista", Klinika.DajOrdinaciju("Internistički").BrojPregleda);
            chart1.Series["Broj pregleda"].Points.AddXY("Ortoped", Klinika.DajOrdinaciju("Ortopedski").BrojPregleda);
            chart1.Series["Broj pregleda"].Points.AddXY("Oftamolog", Klinika.DajOrdinaciju("Oftamološki").BrojPregleda);
            chart1.Series["Broj pregleda"].Points.AddXY("Otorinolaringolog", Klinika.DajOrdinaciju("Otorinolaringološki").BrojPregleda);
            chart1.Series["Broj pregleda"].Points.AddXY("Kardiolog", Klinika.DajOrdinaciju("Kardiološki").BrojPregleda);
            chart1.Series["Broj pregleda"].Points.AddXY("Dermatolog", Klinika.DajOrdinaciju("Dermatološki").BrojPregleda);
            chart1.Series["Broj pregleda"].Points.AddXY("Laborant", Klinika.DajOrdinaciju("Laborantski").BrojPregleda);
            chart1.Series["Broj pregleda"].Points.AddXY("Doktor opste medicine", Klinika.DajOrdinaciju("Opšti").BrojPregleda);
        }
    }
}
