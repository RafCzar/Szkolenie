using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06___InstrukcjaIfElse_cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              
            do programu w ktorym wyliczalismy wspolczynnik masy ciala doloz jeszcze odpowiedni komunikat co to wyliczone BMI oznacza
            
            mniej niż 16 - wygłodzenie
            16 - 16.99 - wychudzenie
            17 - 18.49 - niedowaga
            18.5 - 24.99 - wartość prawidłowa
            25 - 29.99 - nadwaga
            30 - 34.99 - I stopień otyłości
            35 - 39.99 - II stopień otyłości
            powyżej lub rowno 40 - otyłość skrajna

            */

            double waga, wzrost, wynikBMI;
            string komunikat;

            Console.Write("Podaj swoja wage: ");
            waga = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj swoj wzrost: ");
            wzrost = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            wynikBMI = waga / (Math.Pow(wzrost, 2));

            if (wynikBMI < 16)
            {
                komunikat = "wygłodzenie";
            }
            else if (wynikBMI < 17)
            {
                komunikat = "wychudzenie";
            }
            else if (wynikBMI < 18.5)
            {
                komunikat = "niedowaga";
            }
            else if (wynikBMI < 25)
            {
                komunikat = "wartość prawidłowa";
            }
            else if (wynikBMI < 30)
            {
                komunikat = "nadwaga";
            }
            else if (wynikBMI < 35)
            {
                komunikat = "I st";
            }
            else if (wynikBMI < 40)
            {
                komunikat = "II st";
            }
            else komunikat = "III st";

            Console.WriteLine($"Twoje BMI wynosi: {wynikBMI} -> {komunikat}");

            /*
              Napisz program ktory przyjmie od uzytkownika 3 liczby
              i wypisze na konsoli najmniejsza oraz najwieksza z nich
             */

            Console.WriteLine("Podaj pierwsza liczbe: ");
            int liczbaPierwsza = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbe: ");
            int liczbaDruga = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj trzecia liczbe: ");
            int liczbaTrzecia = Convert.ToInt32(Console.ReadLine());

            int najmniejszaLiczba = liczbaPierwsza;
            int najwiekszaLiczba = liczbaDruga;

            if (liczbaDruga < najmniejszaLiczba)
                najmniejszaLiczba = liczbaDruga;
            if (liczbaTrzecia < najmniejszaLiczba)
                najmniejszaLiczba = liczbaTrzecia;

            if (liczbaPierwsza > najwiekszaLiczba)
                najwiekszaLiczba = liczbaPierwsza;
            if (liczbaTrzecia > najwiekszaLiczba)
                najwiekszaLiczba = liczbaTrzecia;

            Console.WriteLine($"Najmniejsza liczba: {najmniejszaLiczba} , najwieksza liczba : {najwiekszaLiczba}");

            Console.ReadKey();

        }
    }
}
