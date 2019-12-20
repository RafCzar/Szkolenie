using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab39___Delegaty
{
    class Program
    {
        static void KonsolaA(string x)
        {
            Console.WriteLine($"KonsolaA {x}");
        }

        static void KonsolaB(string x)
        {
            Console.WriteLine($"KonsolaB {x}");
        }

        static string Dodaj(int x, int y)
        {
            return $"Dzialanie Dodaj";
        }

        static string Odejmij(int x, int y)
        {
            return $"Dzialanie Odejmij";
        }

        delegate void Drukuj(string x);
        delegate string Licz(int x, int y);
        static void Main(string[] args)
        {
            Drukuj drukuj = KonsolaA;
            drukuj("jakis tekst");
            drukuj += KonsolaB;
            drukuj("jakis tekst");

            Console.WriteLine("================");
            Licz licz = Dodaj;
            Console.WriteLine(licz(1, 4));
            licz += Odejmij;
            Console.WriteLine(licz(1, 4));

            Console.ReadKey();
        }
    }
}
