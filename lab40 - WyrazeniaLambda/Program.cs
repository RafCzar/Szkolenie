using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab40___WyrazeniaLambda
{
    class Program
    {

        delegate int Power(int i);
        delegate void PrintHello(string name);
        static void Main(string[] args)
        {
            //List<Pracownik> listaPracownikow = new List<Pracownik>()
            //{
            //    new Pracownik{Id = 1, Name = "Paweł"},
            //    new Pracownik{Id = 2, Name = "Adam"},
            //    new Pracownik{Id = 3, Name = "Staś"},
            //    new Pracownik{Id = 4, Name = "Amelia"},
            //    new Pracownik{Id = 5, Name = "Ignacy"}
            //};

            //Pracownik pracownik = new Pracownik();

            //foreach (var p in listaPracownikow)
            //{
            //    if (p.Id == 3)
            //    {
            //        pracownik = p;
            //    }
            //}

            //Console.WriteLine($"{pracownik.Id} {pracownik.Name}");

            //Pracownik pracownik = listaPracownikow.Find(p => p.Id == 3);
            //Console.WriteLine($"{pracownik.Id} {pracownik.Name}");

            //Power power = x => x * x;
            //Console.WriteLine(power(17));

            //PrintHello printHello = name => { string text = "Witaj " + name; Console.WriteLine(text); };
            //printHello("Kubus puchatek");

            Func<int, int, int> kwadrat = (x,y) => x * y;
            Console.WriteLine(kwadrat(14,2));

            Func<string> powitaj = () => "cokolwiek";
            Console.WriteLine(powitaj());

            Console.ReadKey();



        }
    }
}
