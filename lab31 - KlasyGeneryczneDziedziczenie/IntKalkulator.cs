using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab31___KlasyGeneryczneDziedziczenie
{
    class IntKalkulator : Kalkulator<int>
    {
        public override int Dodaj(int x, int y)
        {
            return x + y;
        }

        public override int Odejmij(int x, int y)
        {
            return x - y;
        }
    }
}
