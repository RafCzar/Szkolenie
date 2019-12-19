using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab26___KlasaKlasyZagniezdzone
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();
            Console.WriteLine(samochod.PokazMoc());

            samochod.silnik = new Samochod.Silnik();
            Console.WriteLine(samochod.PokazMoc());

            Console.ReadKey();
        }
    }
}
