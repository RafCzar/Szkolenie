#define for1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09___Petle
{
    class Program
    {
        static void Main(string[] args)
        {

#if (for1)

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                    //continue;
                    break;
                Console.WriteLine(i);
            }

#elif (for2)

            List<int> lista = new List<int>()
            {
                44, 12, 78, 3
            };

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{i} -> {lista[i]}");
            }

#elif (foreach1)

            foreach (var item in "szkolenie")
            {
                Console.WriteLine(item);
            }

#elif (foreach2)

            List<int> lista = new List<int>()
            {
                44, 12, 78, 3
            };

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

#elif (while)

            int licznik = 0;

            while (licznik < 10)
            {
                Console.WriteLine(licznik);
                licznik++;
            }

#elif (doWhile)

            int licznik = 0;
            do
            {
                Console.WriteLine(licznik);
                licznik++;
            } while (licznik < 10);

#endif

            Console.ReadKey();

        }
    }
}
