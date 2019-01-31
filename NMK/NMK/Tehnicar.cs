using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class Tehnicar
    {
        private Decimal plata;
        private String korisnickoIme;
        private String lozinka;
        private String imeIPrezime;

        public decimal Plata { get => plata; set => plata = 700m; }
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

        public Tehnicar() { }

        public Decimal IsplatiPlatu() { return Plata; }
        public void NapraviRasporedPregleda(Pacijent P, List<String> L) { P.NapraviRasporedPregleda(L); }
        public  List<String> DajRasporedPregleda(Pacijent P) { return P.DajRasporedPregleda(); }

        public void RegistrujTehnicara(string ip, string ki, string l)
        {
            ImeIPrezime = ip;
            KorisnickoIme = ki;
            Lozinka = l;
        }
    }
}
