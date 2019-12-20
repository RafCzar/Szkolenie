using lab43___dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab43___dllImport
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasMath km = new KlasMath();
            Console.WriteLine(km.Dodaj(2, 4));
            Console.ReadKey();
        }
    }
}
