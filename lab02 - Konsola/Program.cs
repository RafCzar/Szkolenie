#define przyklad4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02___Konsola
{
    class Program
    {
        static void Main(string[] args)
        {

#if(przyklad1)

            string imie = "Rafal";
            string nazwisko = "Czarkowski";
            Console.WriteLine("Witaj " + imie + " " + nazwisko);

            Console.WriteLine("Witaj {0} {1}", imie, nazwisko);

            Console.WriteLine($"Witaj {imie} {nazwisko}");

#elif(przyklad2)

            Console.Write("Podaj jakis tekst: ");

            string jakisTekst;

            jakisTekst = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(jakisTekst);

#elif(przyklad3)

            int liczba;

            Console.Write("Podaj jakas liczbe: ");

            liczba = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Twoja liczba to: {liczba}");

#elif(przyklad4)

            Console.WriteLine("pierwszy komunikat");

            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("drugi komunikat");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("trzeci komunikat");

            Console.ResetColor();

            Console.WriteLine("czwarty komunikat");

#endif
            Console.ReadKey();
        }
    }
}
