using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab31___KlasyGeneryczneDziedziczenie
{
    abstract class Kalkulator<T>
    {
        public abstract T Dodaj(T x, T y);

        public abstract T Odejmij(T x, T y);
    }
}
