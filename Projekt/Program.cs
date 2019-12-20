using Projekt.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        static File file;

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Lista");
            Console.WriteLine("2 - Raport miesieczny");
            Console.WriteLine("3 - Dodaj wydatek");
            Console.WriteLine("4 - Dodaj dochód");
            Console.WriteLine("5 - Usuń pozycję");
            Console.WriteLine("6 - Zakończ");
            Console.WriteLine("Wybrana opcja: ");
        }

        private static void RunSelected(string selected)
        {
            switch (selected)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Wszystkie pozycje:");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Raport dla aktualnego miesiaca");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Nowy wydatek");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Nowy dochód");
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Podaj ID pozycji do usuniecia");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            file = new File();

            string selected;

            do
            {
                DisplayMenu();
                selected = Console.ReadLine();
                RunSelected(selected);
            } while (selected != "6");
        }
    }
}
