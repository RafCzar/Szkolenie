using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab19___KlasyKonstruktoryKopiujace
{
    class Samochod
    {
        public string marka;
        public int iloscDrzwi;

        public Samochod(string marka, int iloscDrzwi)
        {
            this.marka = marka;
            this.iloscDrzwi = iloscDrzwi;
        }

        public Samochod(Samochod samochod)
        {
            this.marka = samochod.marka;
            this.iloscDrzwi = samochod.iloscDrzwi;
            Console.WriteLine("konstruktor kopiujacy");
        }
    }
}
