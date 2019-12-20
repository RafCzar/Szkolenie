using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab42___PetlaWspolbiezna
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(1, 200, (n) =>
            {
                if ((n % 8) == 0)
                {
                    Console.WriteLine($"liczba {n} jest podzielna przez 8");
                }
            });

            Console.ReadKey();
        }
    }
}
