using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class Doktor
    {
        static Int32 GRANICA_BROJA_PREGLEDA = 20;
        private Decimal osnovnaPlata;
        private Int32 brojPregleda;
        private String struka;
        private String korisnickoIme;
        private String lozinka;
        private String imeIPrezime;

        public Doktor(String struka)
        {
            osnovnaPlata = 2000m;
            BrojPregleda = 0;
            Struka = struka;
        }

        public static int GRANICA_BROJA_PREGLEDA1 { get => GRANICA_BROJA_PREGLEDA; }
        public decimal OsnovnaPlata { get => osnovnaPlata; }
        public int BrojPregleda { get => brojPregleda; set => brojPregleda = value; }
        public string Struka { get => struka; set => struka = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = CalculateMD5Hash(value); }
        public string ImeIPrezime { get => imeIPrezime; set => imeIPrezime = value; }

        public string CalculateMD5Hash(string input)
        { 
            // step 1, calculate MD5 hash from input
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }


        public Decimal IsplatiPlatu()
        {
            if (BrojPregleda == 0) return OsnovnaPlata;
            else if (BrojPregleda < GRANICA_BROJA_PREGLEDA1) return OsnovnaPlata + OsnovnaPlata * 0.05m * BrojPregleda;
            return OsnovnaPlata + OsnovnaPlata * 0.05m * GRANICA_BROJA_PREGLEDA1;
        }

        public void ObaviPregled() { BrojPregleda++; }

        public void RegistrujDoktora(string ip, string ki, string l)
        {
            ImeIPrezime = ip;
            KorisnickoIme = ki;
            Lozinka = l;
        }
    }
}
