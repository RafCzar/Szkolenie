using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17___KlasyMetody
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();

            samochod.marka = "BMW";
            samochod.rokProdukcji = 2000;
            samochod.maksymalnaPredkosc = 190;

            samochod.PokazAuto();
            Console.WriteLine("================");
            samochod.Zwolnij(50);
            Console.WriteLine(samochod.aktualnaPredkosc);

            samochod.Przyspiesz(300);
            Console.WriteLine(samochod.aktualnaPredkosc);

            Console.ReadKey();

        }
    }
}
