using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolenie
{
    class Program
    {
        static void Main(string[] args)
        {
      
            int[,] tablica = new int[10, 10];

            Random random = new Random();

            for (int rowNumber = 0; rowNumber < tablica.GetLength(0); rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < tablica.GetLength(0); columnNumber++)
                {
                    tablica[rowNumber, columnNumber] = random.Next(999);
                }
            }

            for (int rowNumber = 0; rowNumber < tablica.GetLength(0); rowNumber++)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("-----------------------------------------------------------");
                Console.Write("| ");
                for (int columnNumber = 0; columnNumber < tablica.GetLength(0); columnNumber++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(Convert.ToString(tablica[rowNumber, columnNumber]).PadRight(3));
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(" | ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("-----------------------------------------------------------");

            int maksymalnyElement = 0;
            string pozycjaMaksymalnegoElementu = "";

            for (int rowNumber = 0; rowNumber < tablica.GetLength(0); rowNumber++)
            {
                for (int columnNumber = 0; columnNumber < tablica.GetLength(0); columnNumber++)
                {
                    if ((tablica[rowNumber, columnNumber]) > maksymalnyElement)
                    {
                        maksymalnyElement = tablica[rowNumber, columnNumber];
                        pozycjaMaksymalnegoElementu = $"wiersz: {rowNumber + 1}, kolumna: {columnNumber + 1}";
                    }
                }
            }

            Console.WriteLine($"{maksymalnyElement} -> {pozycjaMaksymalnegoElementu}");

            Console.ReadKey();
        }
    }
}
