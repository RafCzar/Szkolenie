using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14___Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("Miłosz");
            lista.Add("Adam");
            lista.Add("Paweł");
            lista.Add("Piotr");
            lista.Add("Karol");
            lista.Add("Adam");
            lista.Add("Łukasz");
            lista.Add("Czesław");

            Console.WriteLine($"ilosc elementow: {lista.Count}");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            lista.RemoveAt(2);

            Console.WriteLine($"ilosc elementow: {lista.Count}");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            string zmienna = lista[4];

            Console.WriteLine(zmienna);  //Adam

            lista.Remove(zmienna);

            Console.WriteLine($"ilosc elementow: {lista.Count}");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
