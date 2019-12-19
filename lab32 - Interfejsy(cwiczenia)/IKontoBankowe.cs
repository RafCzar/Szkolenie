using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab32___Interfejsy_cwiczenia_
{
    interface IKontoBankowe
    {
        decimal Saldo { get; }
        void Wplac(decimal wartosc);
        bool Wyplac(decimal wartosc);
        bool ZrobPrzelew(IKontoBankowe cel, decimal wartosc);

    }
}
