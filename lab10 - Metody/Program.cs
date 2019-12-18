using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10___Metody
{
    class Program
    {
        static string PobierzTekst(string tekst)
        {
            Console.WriteLine(tekst);
            return Console.ReadLine();
        }
        static string DajInicjaly(string imie, string nazwisko)
        {
            return imie[0] + "." + nazwisko[0] + ".";
        }

        static void DrukujDane(string imie, string nazwisko)
        {
            Console.WriteLine($"Nazywasz sie: {imie} {nazwisko}");
        }

        static void DrukujLiczby(int liczba1, int liczba2)
        {
            Console.WriteLine($"{liczba1} {liczba2}");
        }
        static void DrukujLiczby(int liczba1, int liczba2, int liczba3)
        {
            Console.WriteLine($"{liczba1} {liczba2} {liczba3}");
        }
        static void DrukujLiczby(double  liczba1, double liczba2)
        {
            Console.WriteLine($"{liczba1} {liczba2}");
        }

        static int ZwrocDlugoscTekstu(string tekst)
        {
            return tekst.Length;
        }

        static void ZwrocDlugoscTekstu(string tekst, out int dlugosc)
        {
            dlugosc = tekst.Length;
        }

        static void Powieksz(string tekst)
        {
            tekst = tekst.ToUpper();
        }

        static void Powieksz(ref string tekst)
        {
            tekst = tekst.ToUpper();
        }

        static void Main(string[] args)
        {
            //string imie = PobierzTekst("podaj imie: ");
            //string nazwisko = PobierzTekst("podaj nazwisko: ");

            //Console.WriteLine($"{imie} {nazwisko}");
            //Console.Write("Twoje inicjaly to: ");

            //Console.WriteLine(DajInicjaly(imie, nazwisko));
            //DrukujDane(imie, nazwisko);

            //DrukujLiczby(1, 2);
            //DrukujLiczby(1, 2, 3);
            //DrukujLiczby(2.2, 2.2);

            //int liczbaInt = ZwrocDlugoscTekstu("qwerty123");
            //Console.WriteLine(liczbaInt);

            //ZwrocDlugoscTekstu("qwerty123", out int dlugosc);
            //Console.WriteLine(dlugosc);

            //int jakasInnaDlugosc;

            //ZwrocDlugoscTekstu("qwerty123", out jakasInnaDlugosc);
            //Console.WriteLine(jakasInnaDlugosc);

            string nazwa = "cokolwiek";
            Console.WriteLine(nazwa);
            Powieksz(ref nazwa);
            Console.WriteLine(nazwa);

            //string a = "sdfghj";
            //string b = a;
            ////ref string b = ref a;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //a = "qwerty";

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            Console.ReadKey();

        }
    }
}
