using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12___Tablice
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tablica;
            tablica = new int[] { 11, 23, 67, 89 };

            Console.WriteLine($"dlugosc tablicy : {tablica.Length}");
            Console.WriteLine($"wartosc spod indeksu nr 0: {tablica[0]}");
            tablica[0] = 1234;
            Console.WriteLine($"wartosc spod indeksu nr 0: {tablica[0]}");

            foreach (var item in tablica)
            {
                Console.WriteLine(item);
            }

            int[] tablica2 = new int[10];

            tablica2[0] = 23;
            tablica2[3] = 1234;
            tablica2[6] = 13;

            foreach (var item in tablica2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
