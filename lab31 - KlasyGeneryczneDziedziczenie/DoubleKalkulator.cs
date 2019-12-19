using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab31___KlasyGeneryczneDziedziczenie
{
    class DoubleKalkulator : Kalkulator<double>
    {
        public override double Dodaj(double x, double y)
        {
            return x + y;
        }

        public override double Odejmij(double x, double y)
        {
            return x - y;
        }
    }
}
