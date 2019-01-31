using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class Ordinacija
    {
        private Int32 redCekanja;
        private String tipPregleda;
        private Int32 brojPregleda;
        static Int32 CIJENA_PREGLEDA = 100;

        public Ordinacija(string tipPregleda)
        {
            redCekanja = 0;
            TipPregleda = tipPregleda;
            brojPregleda = 0;
        }

        public string TipPregleda { get => tipPregleda; set => tipPregleda = value; }
        public static int CIJENA_PREGLEDA1 { get => CIJENA_PREGLEDA; }
        public int BrojPregleda { get => brojPregleda; }
        public int RedCekanja { get => redCekanja;  }

        public void PovecajRedCekanja() { redCekanja++; brojPregleda++;  }
        public void SmanjiRedCekanja() { redCekanja--; if (RedCekanja < 0) redCekanja = 0; }
    }
}
