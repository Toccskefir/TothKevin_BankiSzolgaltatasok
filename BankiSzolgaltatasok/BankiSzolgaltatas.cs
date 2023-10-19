using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class BankiSzolgaltatas
    {
        private Tulajdonos tulajdonos;

        public BankiSzolgaltatas(Tulajdonos tulajdonos)
        {
            this.tulajdonos = tulajdonos;
        }

        public Tulajdonos Tulajdonos { get => tulajdonos; }
    }
}
