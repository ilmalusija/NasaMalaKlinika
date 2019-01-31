using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NMK
{
    public class Pacijent : IPlacanje
    {
        private String ime;
        private String prezime;
        private DateTime datumRodjenja;
        private Int64 maticniBroj;
        private String pol;
        private String adresaStanovanja;
        private String vakcinacije;
        private DateTime datumPrijave;
        private List<String> ranijeBolesti;
        private List<String> ranijeAlergije;
        private String bracnoStanje;
        private List<DateTime> datumPregleda;
        private String sadasnjaBolest;
        private String sadasnjaAlergija;
        private String porodicnoZdravstvenoStanje;
        private List<String> zakljucakDoktora;
        private List<String> rasporedPregleda;
        private List<String> garancijaDoktora;
        private List<String> pregledi;
        private List<String> terapije;
        private bool redovni;
        private Int32 dug;
        private String lozinka;
        private Image profilna;
        private DateTime datumSlike;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public long MaticniBroj { get => maticniBroj; set => maticniBroj = ValidirajMaticniBroj(value); }
        public string Pol { get => pol; set => pol = value; }
        public string AdresaStanovanja { get => adresaStanovanja; set => adresaStanovanja = value; }
        public string Vakcinacije { get => vakcinacije; set => vakcinacije = value; }
        public List<string> RanijeBolesti { get => ranijeBolesti; set => ranijeBolesti = value; }
        public List<string> RanijeAlergije { get => ranijeAlergije; set => ranijeAlergije = value; }
        public string BracnoStanje { get => bracnoStanje; set => bracnoStanje = value; }
        public List<DateTime> DatumPregleda { get => datumPregleda; set => datumPregleda = value; }
        public string SadasnjaBolest { get => sadasnjaBolest; set => sadasnjaBolest = value; }
        public string SadasnjaAlergija { get => sadasnjaAlergija; set => sadasnjaAlergija = value; }
        public string PorodicnoZdravstvenoStanje { get => porodicnoZdravstvenoStanje; set => porodicnoZdravstvenoStanje = value; }
        public List<string> ZakljucakDoktora { get => zakljucakDoktora; set => zakljucakDoktora = value; }
        public List<string> RasporedPregleda { get => rasporedPregleda; set => rasporedPregleda = value; }
        public List<string> GarancijaDoktora { get => garancijaDoktora; set => garancijaDoktora = value; }
        public List<string> Terapije { get => terapije; set => terapije = value; }
        public Boolean Redovni { get => redovni; set => redovni = OdrediDaLiJeRedovni(); }
        public int Dug { get => dug; set => dug = value; }
        public DateTime DatumPrijave { get => datumPrijave; set => datumPrijave = value; }
        public List<string> Pregledi { get => pregledi; set => pregledi = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public Image Profilna { get => profilna; set => profilna = value; }
        public DateTime DatumSlike { get => datumSlike; set => datumSlike = value; }

        public long ValidirajMaticniBroj(long value)
        {
            if (value.ToString().Length != 13) throw new Exception("Invalidan maticni broj!");
            return value;
        }

        public bool OdrediDaLiJeRedovni()
        {
            int isti = 0;
            for (int i = 0; i < DatumPregleda.Count; i++)
            {
                for (int j = i + 1; j < DatumPregleda.Count - 1; j++)
                {
                    if (DateTime.Compare(DatumPregleda[i], DatumPregleda[j]) == 0) isti++;
                }
            }
            if (DatumPregleda.Count - isti >= 3) Redovni = true;
            Redovni = false;
            return Redovni;
        } 

        public Pacijent()
        {
            RanijeAlergije = new List<string>();
            ranijeBolesti = new List<string>();
            DatumPregleda = new List<DateTime>();
            ZakljucakDoktora = new List<string>();
            RasporedPregleda = new List<string>();
            GarancijaDoktora = new List<string>();
            Terapije = new List<string>();
            Pregledi = new List<string>();
            Dug = 0;
        }

        public void PopuniElektronskiKarton(String pSadasnjaBolest, String pSadasnjaAlergija, String v, String rb, String ra)
        {
            SadasnjaBolest = pSadasnjaBolest; SadasnjaAlergija = pSadasnjaAlergija;
            Vakcinacije = v; RanijeBolesti.Add(rb); RanijeAlergije.Add(ra);
        }
        public void RegistrujPacijenta(string i, string p, string l, DateTime dr, long m, string pol, string ad, string bs, DateTime dp)
        {
            Ime = i; Prezime = p; Lozinka = l;  DatumRodjenja = dr;
            MaticniBroj = m; Pol = pol; AdresaStanovanja = ad;
            BracnoStanje = bs; DatumPrijave = dp;
        }
        public void AzurirajKarton(string b, string a, string t, string v, string z)
        {
            SadasnjaBolest = b; SadasnjaAlergija = a;
            Terapije.Add(t); ZakljucakDoktora.Add(z);
            Vakcinacije = v;
        }
        public void EvidentirajPregled(string p, DateTime dp, string gd)
        {
            Pregledi.Add(p); DatumPregleda.Add(dp);
            GarancijaDoktora.Add(gd);
        }

        public void NapraviRasporedPregleda(List<String> pRaspored) { RasporedPregleda = pRaspored; }
        public void DodajPregled(string P) { RasporedPregleda.Add(P); }
        public List<String> DajRasporedPregleda()
        {
            return RasporedPregleda;
        }
        public void DodajGarancijuDoktora(String S) { GarancijaDoktora.Add(S); }
        public void DodajTerapiju(String S) { Terapije.Add(S); }
        public Decimal IspostaviRacun(bool GPlacanje)
        {
            this.OdrediDaLiJeRedovni();
            if (Redovni && GPlacanje) return Dug - Dug * 0.1m;
            else if (Redovni && !GPlacanje) return Dug;
            else if (!Redovni && GPlacanje) return Dug;
            return Dug + Dug * 0.15m;
        }
    }
}
