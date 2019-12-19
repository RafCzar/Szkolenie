using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab32___Interfejsy_cwiczenia_
{
    class KontoDrugie : IKontoBankowe
    {
        public decimal Saldo { get; private set; }

        public void Wplac(decimal wartosc)
        {
            Saldo += wartosc;
        }

        public bool Wyplac(decimal wartosc)
        {
            if (Saldo >= wartosc)
            {
                Saldo -= wartosc;
                return true;
            }
            Console.WriteLine("za malo srodkow na koncie");
            return false;
        }

        public bool ZrobPrzelew(IKontoBankowe cel, decimal wartosc)
        {
            bool wyplacono = this.Wyplac(wartosc);
            if (wyplacono)
            {
                cel.Wplac(wartosc);
                return wyplacono;
            }
            return !wyplacono;
        }
    }
}
