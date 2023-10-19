using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class MegtakaritasiSzamla : Szamla
    {
        public static double alapKamat = 1.1;
        private double kamat;

        public MegtakaritasiSzamla(Tulajdonos tulajdonos) : base(tulajdonos)
        {
            this.kamat = alapKamat;
        }

        public double Kamat { get => kamat; set => kamat = value; }

        public override bool Kivesz(int osszeg)
        {
            return this.aktualisEgyenleg >= osszeg;
        }

        public void KamatJovairas()
        {
            this.aktualisEgyenleg = (int)(this.aktualisEgyenleg * this.kamat);
        }
    }
}
