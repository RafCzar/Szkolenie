using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08___TypEnumSwitch_cwiczenia_
{
    class Program
    {
        enum Kawa
        {
            mala,
            srednia,
            duza
        }
        static void Main(string[] args)
        {
            /*Napisz program ktory dla zdefiniowanego typu wyliczeniowego przyjmie 3 rodzaje kawy:
             -mala
             -srednia
             -duza
             
             i bedzie dla nich odpowiednio ustalala cene 3,  4.5,  6
             
             utworz nowa zmienna tego typu i przepusc ja przez instrukcje switch
             i wypisz cene dla aktualnej kawy
             */
            Kawa kawa = Kawa.srednia;

            switch (kawa)
            {
                case Kawa.mala:
                    Console.WriteLine("Kawa mala, cena 3 pln");
                    break;
                case Kawa.srednia:
                    Console.WriteLine("Kawa srednia, cena 4,5 pln");
                    break;
                case Kawa.duza:
                    Console.WriteLine("Kawa duza, cena 6 pln");
                    break;
                default:
                    break;
            }

        }
    }
}
