using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20___KlasyWlasciwosci
{
    class Samochod
    {
        private string marka;
        private int rokProdukcji;
        private int aktualnaPredkosc;
        private int maksymalnaPredkosc;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public int RokProdukcji { get => rokProdukcji; set => rokProdukcji = value; }
        public int AktualnaPredkosc { get => aktualnaPredkosc; set => aktualnaPredkosc = value; }
        public int MaksymalnaPredkosc { get => maksymalnaPredkosc; set => maksymalnaPredkosc = value; }


        public Samochod(string marka, int rokProdukcji, int maksymalnaPredkosc)
        {
            this.marka = marka;
            this.rokProdukcji = rokProdukcji;
            //this.aktualnaPredkosc = 0;
            this.maksymalnaPredkosc = maksymalnaPredkosc;
            Console.WriteLine("zostal wywolany konstruktor 3 parametrowy");
        }

        public Samochod()
        {
            Console.WriteLine("zostal wywolany konstruktor bezparametrowy");
        }

        public Samochod(string marka)
        {
            this.marka = marka;
            Console.WriteLine("zostal wywolany konstruktor 1 parametrowy");
        }

        public Samochod(string marka, int rokProdukcji) : this(marka, rokProdukcji, 200)
        {
            Console.WriteLine("zostal wywolany konstruktor pochodny");
        }

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
