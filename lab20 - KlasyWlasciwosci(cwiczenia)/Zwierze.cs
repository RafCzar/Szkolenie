using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20___KlasyWlasciwosci_cwiczenia_
{
    class Zwierze
    {
        private string nazwa;
        private int iloscOczu;
        private int iloscNog;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int IloscOczu { get => iloscOczu; set => iloscOczu = value; }
        public int IloscNog { get => iloscNog; set => iloscNog = value; }

        public string Opis()
        {
            return $"{nazwa} {iloscOczu} {iloscNog}";
        }

        public void OpisKonsola()
        {
            Console.WriteLine($"{nazwa} {iloscOczu} {iloscNog}");
        }

    }
}
