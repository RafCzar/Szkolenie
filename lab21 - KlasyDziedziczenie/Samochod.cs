using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasyDziedziczenie
{
    class Samochod : Pojazd
    {
        public void PokazAuto()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"Marka: {Marka}{nl}Rok produkcji: {RokProdukcji}{nl}Aktualna predkosc: {AktualnaPredkosc}{nl}Maksymalna predkosc{MaksymalnaPredkosc}");
        }


    }
}
