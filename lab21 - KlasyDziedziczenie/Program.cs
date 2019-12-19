using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasyDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();

            samochod.Marka = "BMW";

            Console.WriteLine(samochod.Marka);

            samochod.PokazAuto();

            Console.ReadKey();
        }
    }
}
