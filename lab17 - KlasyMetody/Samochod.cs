using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17___KlasyMetody
{
    class Samochod
    {
        public string marka;
        public int rokProdukcji;
        public int aktualnaPredkosc;
        public int maksymalnaPredkosc;

        public void PokazAuto()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"Marka: {marka}{nl}Rok produkcji: {rokProdukcji}{nl}Aktualna predkosc: {aktualnaPredkosc}{nl}Maksymalna predkosc{maksymalnaPredkosc}");
        }

        public void Przyspiesz(int wartosc) 
        {
            if (aktualnaPredkosc + wartosc >= maksymalnaPredkosc)
            {
                aktualnaPredkosc = maksymalnaPredkosc;
            }
            else aktualnaPredkosc += wartosc;
        }

        public void Zwolnij(int wartosc)
        {
            if (aktualnaPredkosc - wartosc <= 0)
            {
                aktualnaPredkosc = 0;
            }
            else aktualnaPredkosc -= wartosc;
        }
    }
}
