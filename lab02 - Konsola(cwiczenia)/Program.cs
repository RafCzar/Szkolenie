using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02___Konsola_cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            zdefiniuj dwie zmienne (nic do nich jeszcze nie przypisuj)
            pierwsza z nich typu "string"
            druga typu "int"

            Uruchom konsole:
            popros uzytkownika aby podal swoje imie (utrwal je w zmiennej typu "string")
            popros uzytkownika rowniez o to by podal swoj wiek (utrwal go w zmiennej typu "int")

            wyczysc konsole

            wypisz na konsoli komunikat "Witaj IMIE, masz X lat"
            */

            string imie;
            int wiek;

            Console.Write("podaj swoje imie: ");
            imie = Console.ReadLine();

            Console.Write("podaj swoj wiek: ");
            wiek = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Witaj {imie}, masz {wiek} lat");

            Console.Beep();

            Console.ReadKey();

        }
    }
}
