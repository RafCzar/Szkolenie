using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab34___OdczytZPliku
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = $@"d:\test.txt";

            string tekst = "";

            if (File.Exists(path))
            {
                Console.WriteLine("plik istnieje");
                //tekst = File.ReadAllText(path);

                List<string> lines = new List<string>(File.ReadAllLines(path));

                foreach (var item in lines)
                {
                    Console.WriteLine(item);
                }

            }
            else Console.WriteLine("pliku brak");

            Console.WriteLine(tekst);

            Console.ReadKey();
        }
    }
}
