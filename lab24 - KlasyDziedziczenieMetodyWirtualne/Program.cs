using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasyDziedziczenieMetodyWirtualne
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt2d a = new Punkt2d(1, 2);
            Console.WriteLine(a.PokazWspolrzedne());

            Punkt3d b = new Punkt3d(5, 10, 15);
            Console.WriteLine(b.PokazWspolrzedne());

            Punkt2d c = new Punkt3d(100, 200, 300);
            Console.WriteLine(c.PokazWspolrzedne());

            Console.ReadKey();
        }
    }
}
