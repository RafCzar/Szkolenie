using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17___KlasyMetody_cwiczenia_
{
    class Zwierze
    {
        public string nazwa;
        public int iloscOczu;
        public int iloscNog;

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
