using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab31___KlasyGeneryczneDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            IntKalkulator ik = new IntKalkulator();
            Console.WriteLine(ik.Dodaj(2, 6));
            Console.WriteLine(ik.Odejmij(5, 1));

            DoubleKalkulator dk = new DoubleKalkulator();
            Console.WriteLine(dk.Dodaj(2.5, 2.2));
            Console.WriteLine(dk.Odejmij(1.2, 0.2));

            Console.ReadKey();
        }
    }
}
