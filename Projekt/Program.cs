using Projekt.Db;
using Projekt.Statistics;
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
                    //Console.Clear();
                    //Console.WriteLine("Wszystkie pozycje:");
                    //Console.ReadKey();
                    ShowList();
                    break;
                case "2":
                    //Console.Clear();
                    //Console.WriteLine("Raport dla aktualnego miesiaca");
                    //Console.ReadKey();
                    ShowReport();
                    break;
                case "3":
                    //Console.Clear();
                    //Console.WriteLine("Nowy wydatek");
                    //Console.ReadKey();
                    AddOutcome();
                    break;
                case "4":
                    //Console.Clear();
                    //Console.WriteLine("Nowy dochód");
                    //Console.ReadKey();
                    AddIncome();
                    break;
                case "5":
                    //Console.Clear();
                    //Console.WriteLine("Podaj ID pozycji do usuniecia");
                    //Console.ReadKey();
                    RemoveItem();
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

        private static void ShowList()
        {
            Console.Clear();
            List list = new List(file);

            Console.WriteLine("Wszystkie pozycje:");
            list.DisplayList();

            Console.ReadKey();
        }

        private static void ShowReport()
        {
            Console.Clear();

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            Summary report = new Summary(file);

            report.DisplayReport(year, month);

            Console.ReadKey();
        }

        private static void AddOutcome()
        {
            Console.Clear();
            Console.WriteLine("Nowy wydatek:");

            Console.WriteLine("Nazwa wydatku:");
            string name = Console.ReadLine();

            Console.WriteLine("Kwota wydatku:");
            decimal amount = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Data wydatku:");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Service service = new Service(file, file);

            service.AddOutcome(name, amount, date);
        }

        private static void AddIncome()
        {
            Console.Clear();
            Console.WriteLine("Nowy dochód:");

            Console.WriteLine("Nazwa dochodu:");
            string name = Console.ReadLine();

            Console.WriteLine("Kwota dochodu:");
            decimal amount = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Data dochodu:");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Service service = new Service(file, file);

            service.AddIncome(name, amount, date);
        }

        private static void RemoveItem()
        {
            Console.Clear();
            Console.WriteLine("Podaj id wpisuj do usunięcia:");
            int id = Int32.Parse(Console.ReadLine());

            Service service = new Service(file, file);
            service.RemoveById(id);
        }

    }
}
