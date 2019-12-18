#define cwiczenie4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03___ZmienneTypyDanych_cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {

#if (cwiczenie1)
            /*
            Napisz program wypisujacy dzien roku i sprawdzajacy czy aktualny rok jest rokiem przestepnym. Skorzystaj z klasy DateTime.
            1.zadeklaruj zmienna typu DateTime i przypisz jej aktualna date (skorzystaj z wlasciwosci "Today")
            2.wypisz na konsoli obecny dzien roku (skorzystaj z wlasciwosci "DayOfYear")
            3.wypisz na konsoli czy biezacy rok jest rokiem przestepnym
            (skorzystaj z metody "IsLeapYear")
            */

            DateTime aktualnaData = DateTime.Today;
            Console.WriteLine(aktualnaData.DayOfYear);
            Console.WriteLine(DateTime.IsLeapYear(aktualnaData.Year));

#elif(cwiczenie2)

            /*
            Napisz program ktory bedzie sprawdzal jaki jutro bedzie dzien tygodnia. Skorzystaj z klasy DateTime
            1.zadeklaruj zmienna typu DateTime i przypisz jej aktualna date (skorzystaj z wlasciwosci "Today")
            2.przypisz do zadeklarowanej zmiennej kolejny dzien tygodnia (wykorzystaj metode AddDays() )
            3.wypisz na konsoli dzien tygodnia dla swojej zmiennej (skorzystaj z wlasciwosci DayOfWeek)
            */

            DateTime jakasData = DateTime.Today;
            jakasData = jakasData.AddDays(1);
            Console.WriteLine(jakasData.DayOfWeek);

#elif(cwiczenie3)

            /* TODO 3
             Napisz program ktory przyjmie od uzytkownika jego imie i nazwisko (do jednej zmiennej typu string)
             1.zadeklaruj zmienna typu "string"
             2.napisz na konsoli zachete aby uzytkownik wprowadzil swoje imie i nazwisko 
             3.zapisz te dane w zmiennej typu string
             4.powieksz do duzych znakow dane wprowadzone przez uzytkownika 
             5.zaprezentuj na konsoli pierwszych 6 znakow z tego co podal uzytkownik
             */

            string imieNazwisko;
            Console.Write("Podaj imie i nazwisko: ");
            imieNazwisko = Console.ReadLine();
            Console.Clear();
            imieNazwisko = imieNazwisko.ToUpper().Substring(0, 6);

            Console.WriteLine(imieNazwisko);

#elif(cwiczenie4)

            /* 
             Napisz program ktory bedzie wykowal dzielenie jednej zmiennej przez druga
             
            1.zadeklaruj dwie zmienne typu float
            2.do pierwszej zmiennej przypisz jakas wartosc
            3.do drugiej zmiennej przypisz wartosc zero
            4.wykonaj na konsoli dzielenie pierwszej zmiennej przez druga zmienna
           */

            float dzielna = 2.0f;
            float dzielnik = 0;

            Console.WriteLine(dzielna / dzielnik);

#endif

            Console.ReadKey();

        }
    }
}
