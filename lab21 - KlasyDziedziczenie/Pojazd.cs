using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21___KlasyDziedziczenie
{
    class Pojazd
    {
        private string marka;
        private int rokProdukcji;
        private int aktualnaPredkosc;
        private int maksymalnaPredkosc;

        public string Marka { get => marka; set => marka = value; }
        public int RokProdukcji { get => rokProdukcji; set => rokProdukcji = value; }
        public int AktualnaPredkosc { get => aktualnaPredkosc; set => aktualnaPredkosc = value; }
        public int MaksymalnaPredkosc { get => maksymalnaPredkosc; set => maksymalnaPredkosc = value; }
    }
}
