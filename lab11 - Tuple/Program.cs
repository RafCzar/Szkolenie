using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11___Tuple
{
    class Program
    {
        static (string imie, string nazwisko) DajOsobe()
        {
            var nazwa = (imie:"Jan", nazwisko:"Kowalski");
            return nazwa;
        }
        static void Main(string[] args)
        {
            var nazwa = DajOsobe();
            Console.WriteLine(nazwa);
            Console.WriteLine(nazwa.Item1);
            Console.WriteLine(nazwa.Item2);
            Console.WriteLine(nazwa.GetType());

            var tuple = Tuple.Create("pierwszy", "drugi", "trzeci", "czwarty", "piaty", "szosty","siodmy","osmy");

            Console.WriteLine(tuple.GetType());

            Console.ReadKey();
        }
    }
}
