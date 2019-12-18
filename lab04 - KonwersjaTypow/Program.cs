using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04___KonwersjaTypow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rzutowanie niejawne
            byte numer1 = 255;
            int numer2 = numer1;

            Console.WriteLine(numer2);

            //Rzutowanie jawne
            int numer3 = 400;
            byte numer4 = (byte)numer3;

            Console.WriteLine(numer4);


            //Convert
            int numer5 = 255;
            byte numer6 = Convert.ToByte(numer5);


            Console.WriteLine(numer6);

            //Parse
            string numer7 = "200";
            byte numer8 = byte.Parse(numer7);

            Console.WriteLine(numer8);

            Console.ReadKey();



        }
    }
}
