using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal sealed class Tulajdonos
    {
        private string nev;

        public Tulajdonos(string nev)
        {
            this.nev = nev;
        }

        public string Nev { get => nev; set => nev = value; }
    }
}
