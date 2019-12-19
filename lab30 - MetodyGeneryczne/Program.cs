using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab30___MetodyGeneryczne
{
    class Program
    {
        public static void Zamien<T> (ref T a, ref T b)
        {
            T tmp;

            tmp = a;

            a = b;
            b = tmp;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 33;

            Console.WriteLine($"a: {a} | b: {b}");

            Zamien(ref a, ref b);

            Console.WriteLine($"a: {a} | b: {b}");

            Console.WriteLine("======================");

            string c = "cCc";
            string d = "dDdDdDdDd";

            Console.WriteLine($"c: {c} | d: {d}");

            Zamien/*<string>*/(ref c, ref d);

            Console.WriteLine($"c: {c} | d: {d}");

            Console.ReadKey();

        }
    }
}
