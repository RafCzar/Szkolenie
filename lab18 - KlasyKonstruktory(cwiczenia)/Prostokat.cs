using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18___KlasyKonstruktory_cwiczenia_
{
    class Prostokat
    {
        public int szerokosc;
        public int wysokosc;
        public Punkt lewyDolny;
        public Punkt prawyDolny;
        public Punkt lewyGorny;
        public Punkt prawyGorny;

        public Prostokat(Punkt lewyDolny, int szerokosc, int wysokosc)
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            this.lewyDolny = lewyDolny;
            this.prawyDolny = new Punkt(lewyDolny.x + szerokosc, lewyDolny.y);
            this.lewyGorny = new Punkt(lewyDolny.x, lewyDolny.y + wysokosc);
            this.prawyGorny = new Punkt(lewyDolny.x + szerokosc, lewyDolny.y + wysokosc);
        }

        public void PokazDaneProstokata()
        {
            Console.WriteLine($"szerokosc: {szerokosc}");
            Console.WriteLine($"wysokosc: {wysokosc}");
            Console.WriteLine($"lewyDolny: {lewyDolny.x},{lewyDolny.y}");
            Console.WriteLine($"prawyDolny: {prawyDolny.x},{prawyDolny.y}");
            Console.WriteLine($"lewyGorny: {lewyGorny.x},{lewyGorny.y}");
            Console.WriteLine($"prawyGorny: {prawyGorny.x},{prawyGorny.y}");
        }

    }
}
