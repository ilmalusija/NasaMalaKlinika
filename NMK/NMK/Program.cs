using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMK
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Klinika klinika = new Klinika();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Doktor D = new Doktor("Ortoped");
            D.Lozinka = "doktor123";
            D.KorisnickoIme = "ilmich";
            klinika.DodajDoktora(D);
            Pacijent P = new Pacijent();
            P.MaticniBroj = 1234567891234;
            P.Lozinka = "pacijent";
            klinika.DodajPacijenta(P);
            Tehnicar T = new Tehnicar();
            T.Lozinka = "tehnicar";
            T.KorisnickoIme = "ilmich";
            klinika.DodajTehnicara(T);
            Application.Run(new Form1(klinika));
        }
    }
}
