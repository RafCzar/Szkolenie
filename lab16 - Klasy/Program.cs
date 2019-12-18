using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16___Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();

            samochod.marka = "BMW";
            samochod.rokProdukcji = 2000;
            samochod.maksymalnaPredkosc = 190;

            string nl = Environment.NewLine;

            Console.WriteLine($"{samochod.marka}{nl}{samochod.rokProdukcji}\n{samochod.aktualnaPredkosc}\n{samochod.maksymalnaPredkosc}");

            Samochod s = new Samochod();

            Console.WriteLine(s.aktualnaPredkosc);

            Console.ReadKey();
        }
    }
}
