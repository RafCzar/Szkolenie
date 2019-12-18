#define cwiczenie3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09___Petle_cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {

#if (cwiczenie1)

            /* 
             Napisz program ktory wypisze na konsole wszystkie liczby parzyste 
             w zakresie od 1 do wartosci zadeklarowanej przez uzytkownika
            */

            Console.Write("Podaj liczbe:");
            int zmienna = int.Parse(Console.ReadLine());

            for (int i = 0; i < zmienna; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

#elif (cwiczenie2)

            /*
              Napisz program ktory od uzytkownika przyjmie jakis tekst
              i podliczy ile w tym tekscie jest:
              znakow alfabetu, cyfr i bialych znakow
              
            Char:
            IsLetter
            IsWhiteSpace
            IsNumber
            */

            Console.Write("Podaj jakis tekst: ");
            string jakisTekst = Console.ReadLine();

            int iloscZnakowAlfabetu = 0;
            int iloscZnakowBialych = 0;
            int iloscCyfr = 0;

            foreach (var znak in jakisTekst)
            {
                if (Char.IsWhiteSpace(znak))
                    iloscZnakowBialych++;
                if (Char.IsLetter(znak))
                    iloscZnakowAlfabetu++;
                if (Char.IsNumber(znak))
                    iloscCyfr++;
            }

            string nl = Environment.NewLine;

            Console.WriteLine($"Ilosc cyfr: {iloscCyfr}{nl}Ilosc znakow alfabetu: {iloscZnakowAlfabetu}{nl}Ilosc białych znaków: {iloscZnakowBialych}");

#elif(cwiczenie3)

            /*
            sprawdz czy podana przez uzytkownika liczba jest liczba pierwsza
            */
            Console.Write("Podaj liczbe:");
            int zmienna = int.Parse(Console.ReadLine());

            for (int i = 2; i <= zmienna; i++)
            {
                Console.WriteLine($"{zmienna} / {i}");

                if (zmienna % i != 0)
                {
                    continue;
                }
                else if (zmienna % i == 0 && zmienna != i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Podana liczba {zmienna} nie jest liczba pierwsza gdyz dzieli sie m.in. przez {i}");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Podana liczba {zmienna} jest liczba pierwsza");
                }
            }

#endif

            Console.ReadKey();
        }
    }
}
