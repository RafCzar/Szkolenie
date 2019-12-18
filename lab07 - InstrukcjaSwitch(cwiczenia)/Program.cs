using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07___InstrukcjaSwitch_cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Napisz instrukcje SWITCH ktora przyjmie aktualny dzien tygodnia (skorzystaj z DateTime z wlasciwosci Now DayOfWeek) i wyswietli odpwiedni komunikat po polsku, np. Jest Wtorek
            */

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("jest niedziela");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("jest poniedziałek");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("jest wtorek");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("jest sroda");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("jest czwartek");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("jest piatek");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("jest sobota");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
