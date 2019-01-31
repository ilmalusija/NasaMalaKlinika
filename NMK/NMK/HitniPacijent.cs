using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class HitniPacijent : Pacijent
    {
        private String pomoc;
        private String opravdanjeDoktora;
        private DateTime datumSmrti;
        private String alergijskeReakcije;
        private String opisObdukcije;

        public string Pomoc { get => pomoc; set => pomoc = value; }
        public string OpravdanjeDoktora { get => opravdanjeDoktora; set => opravdanjeDoktora = value; }
        public DateTime DatumSmrti { get => datumSmrti; set => datumSmrti = value; }
        public string AlergijskeReakcije { get => alergijskeReakcije; set => alergijskeReakcije = value; }
        public string OpisObdukcije { get => opisObdukcije; set => opisObdukcije = value; }

        private HitniPacijent() : base() { }
        public void PrvaPomoc(string Pomoc, string Opravdanje)
        {
            this.Pomoc = Pomoc;
            OpravdanjeDoktora = Opravdanje;
        }
        public void ZavediSmrt(DateTime pDatumSmrti, String pAlergijskeReakcije)
        {
            DatumSmrti = pDatumSmrti; AlergijskeReakcije = pAlergijskeReakcije;
        }
        public void Obdukcija(String s)
        {
            OpisObdukcije = s;
        }
    }
}
