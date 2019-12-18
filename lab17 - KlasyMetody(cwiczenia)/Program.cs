using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17___KlasyMetody_cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            skopiuj klase Zwierze z poprzedniego laboratorium
            dorzuc do tej klasy dwie metody:
            Opisz - ktora bedzie zwracala string z calym opisem zwierzaka
            OpiszKonsola - ktora bedzie od razu na konsole wypisywala caly opis zwierzaka

            ConsoleWriteLine(mucha.Opisz());

            mucha.OpiszKonsola();

            */

            Zwierze mucha = new Zwierze();
            mucha.nazwa = "mucha";
            mucha.iloscOczu = 4;
            mucha.iloscNog = 6;

            Zwierze pies = new Zwierze();
            pies.nazwa = "pies";
            pies.iloscOczu = 2;
            pies.iloscNog = 4;

            Zwierze pajak = new Zwierze();
            pajak.nazwa = "pajak";
            pajak.iloscOczu = 8;
            pajak.iloscNog = 8;

            Console.WriteLine(mucha.Opis());
            Console.WriteLine(pies.Opis());
            Console.WriteLine(pajak.Opis());

            mucha.OpisKonsola();
            pies.OpisKonsola();
            pajak.OpisKonsola();

            Console.ReadKey();

        }
    }
}
