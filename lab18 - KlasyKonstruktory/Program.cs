using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18___KlasyKonstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Samochod samochod1 = new Samochod("BMW", 2019, 300);
            //samochod1.PokazAuto();

            //Samochod samochod2 = new Samochod("Audi");

            //Samochod samochod3 = new Samochod();

            Samochod sam = new Samochod("Fiat", 1899);
            Console.WriteLine("=================");
            sam.PokazAuto();

            Console.ReadKey();

        }
    }
}
