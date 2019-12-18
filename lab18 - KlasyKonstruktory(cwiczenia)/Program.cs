using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18___KlasyKonstruktory_cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             przekopiuj klase Zwierze z poprzedniego laboratorium
             utworz w niej dwa konstruktory
             pierwszy z nich ma przyjmowac parametry dla wszystkich pol (3 parametry)
             drugi z nich ma przyjmowac dwa parametry (ten konstruktor ma ustawiac ilosc oczu na 2)

             przetestuj (utworz po egzemplarzu obiektu klasy Zwierze, korzystajac z obu konstruktorow)
             /*
              utworz klase Punkt ktora bedzie skladala sie ze wspolrzednych "x" i "y"
              (dwa zwykle pola typu int)
              utworz konstruktor dla tej klasy, ktory bedzie przyjmowal dwa parametry (czyli ustawi nam wartosci w polach "x" i "y")

            utworz klase Prostokat ktora bedzie sie skladala z 6 pol (4 punkty, dlugosc, szerokosc)
            utworz konstruktor 3 parametrowy dla tej klasy, ma on przyjmowac trzy wartosci:
            -punkt (LewyDolny - jako Punkt)
            -szerokosc (zwykly int)
            -wysokosc (zwykly int)

            wylicz gdzie znajduja sie 3 pozostale wierzcholki tego prostokata

            wyswietl info o tym prostokacie na konsoli

            np w ramach klasy prostokat stworz metode Opisz, ktora uruchomi konsole i zwroci odpowiedni opis, typu:

            dlugosc: 4
            wysokosc: 2
            lewy dolny punkt: 2,2
            prawy dolny punkt: 6,2
            lewy gorny punkt: 2,4
            prawy gorny punkt: 6,4
              * */

            Prostokat prostokat = new Prostokat(new Punkt(2,2), 3, 1);
            prostokat.PokazDaneProstokata();

            Console.ReadKey();
        }
    }
}
