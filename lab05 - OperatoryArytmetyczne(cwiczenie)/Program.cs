#define cwiczenie2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05___OperatoryArytmetyczne_cwiczenie_
{
    class Program
    {
        static void Main(string[] args)
        {

#if(cwiczenie1)

            /*
            Napisz program ktory bedzie nam wyliczal wspolczynnik masy ciala na podstawie podanej wagi i wzrostu

            1.utworz zmienne "waga", "wzrost", "wynikBMI"
            2.popros uzytkownika aby podal wartosci dla zmiennych waga i wzrost
            3.utrwal to co podal uzytkownik w tych zmiennych
            4.na podstawie tych zmiennych wylicz wspolczynnik masy ciala
            5.zaprezentuj na konsoli wynik

            1.80 m
            90 kg

            wzor na bmi = waga dzielona na (wzrost do kwadratu)
            */

            double waga, wzrost, wynikBMI;

            Console.Write("Podaj swoja wage: ");
            waga = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj swoj wzrost: ");
            wzrost = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            wynikBMI = waga / (Math.Pow(wzrost, 2));

            Console.WriteLine($"Twoje BMI wynosi: {wynikBMI}");

#elif (cwiczenie2)

            /*
             
            Napisz program ktory przyjmie dlugosc boku kwadratu
            i wyliczy jego pole oraz obwod

            1.zadeklaruj zmienna dla boku kwadratu
            2.popros uzytkownika o podanie dlugosci boku kwadratu
            3.wylicz pole kwadratu
            4.wylicz obwod kwadratu
            5.zaprezentuj wyniki na konsoli

            */

            decimal dlugoscBokuKwadratu;
            Console.Write($"podaj dlugosc boku kwadratu:");
            dlugoscBokuKwadratu = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"pole kwadratu: {dlugoscBokuKwadratu * dlugoscBokuKwadratu}");
            Console.WriteLine($"obwod kwadratu: {4 * dlugoscBokuKwadratu}");

#endif

            Console.ReadKey();

        }
    }
}
