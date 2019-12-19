using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab29___KlasyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            lista.Add("abc");
            lista.Add('c');
            lista.Add(2);

            foreach (var item in lista)
            {
                Console.WriteLine($"{item} -> {item.GetType()}");
            }

            var zmiennaString = new Generyczna<string>();
            zmiennaString.NadajWartosc("jakis string");
            Console.WriteLine(zmiennaString.ZwrocWartosc());

            var zmiennaInt = new Generyczna<int>();
            zmiennaInt.NadajWartosc(23456);
            Console.WriteLine(zmiennaInt.ZwrocWartosc());

            Console.ReadKey();
        }
    }
}
