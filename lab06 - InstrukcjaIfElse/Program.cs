using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06___InstrukcjaIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;

            if (a > b)
            {
                Console.WriteLine("a jest wieksze od b");
            }
            else if (a < b)
            {
                Console.WriteLine("a jest mniejsze od b");
            }
            else
                Console.WriteLine("a jest rowne b");

            int c = 5;

            if (c > 1 && c < 10)
            {
                Console.WriteLine("c jest w przedziale 1 do 10");
            }

            int d = 0;

            if (d  < 1 || d > 10)
            {
                Console.WriteLine("d jest mniejsze od 1 lub jest wieksze od 10");
            }


            Console.ReadKey();

        }
    }
}
