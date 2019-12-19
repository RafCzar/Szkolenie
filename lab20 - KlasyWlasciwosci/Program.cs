using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20___KlasyWlasciwosci
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("Bmw", 2000);

            samochod.Marka = "jednak nie Bmw";

            Console.WriteLine(samochod.Marka);

            Console.ReadKey();

        }
    }
}
