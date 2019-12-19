using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22___KlasyAbstrakcyjne
{
    abstract class Pojazd
    {
        protected string marka;
        protected int rokProdukcji;
        protected int aktualnaPredkosc;
        protected int maksymalnaPredkosc;
        private bool wlaczonySilnik;


        public string Marka { get => marka; set => marka = value; }
        public int RokProdukcji { get => rokProdukcji; set => rokProdukcji = value; }
        public int AktualnaPredkosc { get => aktualnaPredkosc; set => aktualnaPredkosc = value; }
        public int MaksymalnaPredkosc { get => maksymalnaPredkosc; set => maksymalnaPredkosc = value; }
        protected bool WlaczonySilnik { get => wlaczonySilnik; set => wlaczonySilnik = value; }

        public void PokazPredkosc()
        {
            Console.WriteLine($"aktualna predkosc wynosi{AktualnaPredkosc}");
        }

        public abstract void Przyspiesz(int wartosc);
        public abstract void Zwolnij(int wartosc);
        public abstract void Uruchom();
        public abstract void Zatrzymaj();


    }
}
