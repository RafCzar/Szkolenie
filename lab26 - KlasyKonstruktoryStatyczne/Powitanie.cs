using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab26___KlasyKonstruktoryStatyczne
{
    class Powitanie
    {
        public static string wiadomosc;

        static Powitanie()
        {
            Console.WriteLine("konstruktor statyczny");

            DateTime teraz = DateTime.Now;

            if (teraz.Hour < 18)
            {
                wiadomosc = "Dzien dobry";
            }
            else wiadomosc = "Dobry wieczór";
        }

        public Powitanie()
        {
            Console.WriteLine("konstruktor");
        }

    }
}
