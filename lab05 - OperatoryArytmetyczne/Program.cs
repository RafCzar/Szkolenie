using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05___OperatoryArytmetyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 + 5 + "7");

            Console.WriteLine("2 + 5 = " + (2 + 5) );

            Console.WriteLine("5 / 2 = " + (5 / 2.0));

            Console.WriteLine( Math.Pow(2,3) );

            int a = 5;

            a = a + 1;

            Console.WriteLine(a);

            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.WriteLine(++a);

            a += 1;

            Console.ReadKey();

        }
    }
}
