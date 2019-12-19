using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22___KlasyAbstrakcyjne
{
    class Samochod : Pojazd
    {
        public void PokazAuto()
        {
            string nl = Environment.NewLine;
            Console.WriteLine($"Marka: {Marka}{nl}Rok produkcji: {RokProdukcji}{nl}Aktualna predkosc: {AktualnaPredkosc}{nl}Maksymalna predkosc{MaksymalnaPredkosc}");
        }

        public override void Przyspiesz(int wartosc)
        {
            if (WlaczonySilnik)
            {
                if (AktualnaPredkosc + wartosc <= MaksymalnaPredkosc)
                {
                    AktualnaPredkosc += wartosc;
                }
                else AktualnaPredkosc = MaksymalnaPredkosc;
            }
            else Console.WriteLine("wlacz silnik");
        }

        public override void Uruchom()
        {
            WlaczonySilnik = true;
        }

        public override void Zatrzymaj()
        {
            WlaczonySilnik = false;
            AktualnaPredkosc = 0;
        }

        public override void Zwolnij(int wartosc)
        {
            if (WlaczonySilnik)
            {
                if (AktualnaPredkosc - wartosc >= 0)
                {
                    AktualnaPredkosc -= wartosc;
                }
                else AktualnaPredkosc = 0;
            }
            else Console.WriteLine("wlacz silnik");
        }
    }
}
