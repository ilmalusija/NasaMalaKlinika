using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public sealed class Klinika
    {

        private List<Pacijent> pacijenti;
        private List<Doktor> doktori;
        private List<Tehnicar> tehnicari;
        private List<Ordinacija> ordinacije;

        public List<Pacijent> Pacijenti { get => pacijenti; set => pacijenti = value; }
        public List<Doktor> Doktori { get => doktori; set => doktori = value; }
        public List<Tehnicar> Tehnicari { get => tehnicari; set => tehnicari = value; }
        public List<Ordinacija> Ordinacije { get => ordinacije; set => ordinacije = value; }

        public Klinika()
        {
            Pacijenti = new List<Pacijent>();
            Tehnicari = new List<Tehnicar>();
            Doktori = new List<Doktor>();
            Ordinacije = new List<Ordinacija>();
            Ordinacija O1 = new Ordinacija("Opšti");
            Ordinacija O2 = new Ordinacija("Kardiološki");
            Ordinacija O3 = new Ordinacija("Dermatološki");
            Ordinacija O4 = new Ordinacija("Oftamološki");
            Ordinacija O5 = new Ordinacija("Otorinolaringološki");
            Ordinacija O6 = new Ordinacija("Ortopedski");
            Ordinacija O7 = new Ordinacija("Laborantski");
            Ordinacija O8 = new Ordinacija("Stomatološki");
            Ordinacija O9 = new Ordinacija("Internistički");
            Ordinacije.Add(O1); Ordinacije.Add(O2); Ordinacije.Add(O3);
            Ordinacije.Add(O4); Ordinacije.Add(O5); Ordinacije.Add(O6);
            Ordinacije.Add(O7); Ordinacije.Add(O8); Ordinacije.Add(O9);
        }

        public void DodajPacijenta(Pacijent P) { Pacijenti.Add(P); }
        public void DodajDoktora(Doktor D) { Doktori.Add(D); }
        public void DodajTehnicara(Tehnicar T) { Tehnicari.Add(T); }
        public void ObrisiPacijenta(long Broj)
        {
            int ind = -1;
            for (int i = 0; i < Pacijenti.Count; i++)
            {
                if (Pacijenti[i].MaticniBroj == Broj) ind = i;
            }
            Pacijenti.Remove(Pacijenti[ind]);
        }
        public void ObrisiDoktora(string s)
        {
            int ind = -1;
            for (int i = 0; i < Pacijenti.Count; i++)
            {
                if (Doktori[i].KorisnickoIme == s) ind = i;
            }
            Doktori.Remove(Doktori[ind]);
        }
        public void ObrisiTehnicara(string s)
        {
            int ind = -1;
            for (int i = 0; i < Pacijenti.Count; i++)
            {
                if (Tehnicari[i].KorisnickoIme == s) ind = i;
            }
            Tehnicari.Remove(Tehnicari[ind]);
        }
        public Pacijent DajPacijenta(long Broj)
        {
            int ind = -1;
            for (int i = 0; i < Pacijenti.Count; i++)
            {
                if (Pacijenti[i].MaticniBroj == Broj) ind = i;
            }
            return Pacijenti[ind];
        }
        public Tehnicar DajTehnicara(string ki)
        {
            int ind = -1;
            for (int i = 0; i < Tehnicari.Count; i++)
            {
                if (Tehnicari[i].KorisnickoIme == ki) ind = i;
            }
            return Tehnicari[ind];
        }
        public Doktor DajDoktora(string ki)
        {
            int ind = -1;
            for (int i = 0; i < Doktori.Count; i++)
            {
                if (Doktori[i].KorisnickoIme == ki) ind = i;
            }
            return Doktori[ind];
        }
        public Ordinacija DajOrdinaciju(string p)
        {
            int ind = -1;
            for (int i = 0; i < Ordinacije.Count; i++)
            {
                if (Ordinacije[i].TipPregleda == p) ind = i;
            }
            return Ordinacije[ind];
        }
    }
}
