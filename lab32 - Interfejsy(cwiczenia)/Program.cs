using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab32___Interfejsy_cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {/*
            utworz interfejs IKontoBankowe, ktory bedzie posiadal:
            wlasciwosc Saldo(jedynie do odczytu)
            metody:
            Wplac - nic nie zwraca, przyjmuje 1 parametr typu decimal
            Wyplac - zwraca bool, przyjmuje 1 parametr typu decimal
            ZrobPrzelew - zwraca bool, a jako parametry wejsciowe przyjmuje interfejs IKontoBankowe (jako cel) i decimal jako wartosc

            stworz 2 klasy np KontoPierwsze, KontoDrugie, ktore beda implementowaly interfejs konto bankowe
            Rozwin te metody w tych klasach
            */

            IKontoBankowe a = new KontoPierwsze();
            IKontoBankowe b = new KontoDrugie();
            
            a.Wplac(300);
            b.Wplac(500);

            Console.WriteLine($"Konto Pierwsze: {a.Saldo}");
            Console.WriteLine($"Konto Drugie: {b.Saldo}");

            b.ZrobPrzelew(a, 100);

            Console.WriteLine($"Konto Pierwsze: {a.Saldo}");
            Console.WriteLine($"Konto Drugie: {b.Saldo}");

            Console.ReadKey();
        }
    }
}
