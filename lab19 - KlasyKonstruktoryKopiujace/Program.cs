using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab19___KlasyKonstruktoryKopiujace
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod1 = new Samochod("BMW", 5);

            Console.WriteLine(samochod1.marka);
            Console.WriteLine(samochod1.iloscDrzwi);
            Console.WriteLine("==============");

            Samochod samochod3 = samochod1;

            Console.WriteLine("==============");
            Console.WriteLine(samochod3.marka);
            Console.WriteLine(samochod3.iloscDrzwi);

            samochod3.iloscDrzwi = 100;
            Console.WriteLine("==============");
            Console.WriteLine(samochod3.marka);
            Console.WriteLine(samochod3.iloscDrzwi);

            Console.WriteLine("==============");
            Console.WriteLine(samochod1.marka);
            Console.WriteLine(samochod1.iloscDrzwi);

            Samochod samochod2 = new Samochod(samochod1);

            Console.WriteLine("==============");
            Console.WriteLine(samochod2.marka);
            Console.WriteLine(samochod2.iloscDrzwi);

            samochod2.marka = "xxx";

            Console.WriteLine("==============");
            Console.WriteLine(samochod2.marka);
            Console.WriteLine(samochod1.marka);

            Console.ReadKey();
        }
    }
}
