using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07___InstrukcjaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna = 3;

            switch (zmienna)
            {
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("trzy lub cztery");
                    break;
                case 6:
                    Console.WriteLine("szesc");
                    break;
                default:
                    Console.WriteLine("niezdefiniowana");
                    break;
            }

            Console.ReadKey();
        }
    }
}
