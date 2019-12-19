using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasyDziedziczenie
{
    class Program
    {
        static void Wyswietl(Punkt2d p)
        {
            if (p is Punkt3d)
            {
                Console.WriteLine($"Wyswietl: {((Punkt3d)p).PokazWspolrzedne()}");
            }    
            else Console.WriteLine($"Wyswietl: {p.PokazWspolrzedne()}");
        }

        static void Main(string[] args)
        {
            Punkt2d punkt2d = new Punkt2d(2, 5);
            //Console.WriteLine($"punkt2d: {punkt2d.PokazWspolrzedne()}");

            Punkt3d punkt3d = new Punkt3d(2, 5, 3);
            //Console.WriteLine($"punkt3d: {punkt3d.PokazWspolrzedne()}");

            Punkt2d punkt2d_2 = new Punkt3d(10, 20, 30);
            //Console.WriteLine($"punkt2d_2: {punkt2d_2.PokazWspolrzedne()}");
            //Console.WriteLine($"punkt2d_2: {((Punkt3d)punkt2d_2).PokazWspolrzedne()}");

            //Punkt3d punkt3d_2 = (Punkt3d)new Punkt2d(50, 100);  //blad kompilacji
            Punkt3d punkt3d_2 = (Punkt3d)punkt2d_2;
            Console.WriteLine($"punkt3d_2: {punkt3d_2.PokazWspolrzedne()}");

            //Wyswietl(punkt2d);
            //Wyswietl(punkt3d);
            //Wyswietl(punkt2d_2);
            Wyswietl(punkt3d_2);

            Punkt3d p3d = punkt2d as Punkt3d;

            if (p3d == null)
            {
                Console.WriteLine(punkt2d.PokazWspolrzedne());
            }
            else Console.WriteLine(p3d.PokazWspolrzedne());


            Console.ReadKey();
        }
    }
}
