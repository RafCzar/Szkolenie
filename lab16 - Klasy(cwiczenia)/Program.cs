using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16___Klasy_cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Utworz klase Zwierze skladajaca sie z pol:
             * nazwa
             * iloscOczu
             * iloscNog
             * 
             * w metodzie Main utworz trzy zwierzaki:
             * psa
             * muche
             * pająka
             * 
             * przypisz im odpowiednie parametry
             * 
             * i zaprezentuj te zwierzaki na konsoli
             */

            Zwierze mucha = new Zwierze();
            mucha.nazwa = "mucha";
            mucha.iloscOczu = 4;
            mucha.iloscNog = 6;

            Zwierze pies = new Zwierze();
            pies.nazwa = "pies";
            pies.iloscOczu = 2;
            pies.iloscNog = 4;

            Zwierze pajak = new Zwierze();
            pajak.nazwa = "pajak";
            pajak.iloscOczu = 8;
            pajak.iloscNog = 8;

            string nl = Environment.NewLine;
            
            Console.WriteLine($"Obiekt mucha:{nl}nazwa: {mucha.nazwa}{nl}ilosc oczu: {mucha.iloscOczu}{nl}ilosc nog: {mucha.iloscNog}{nl}");
            Console.WriteLine($"Obiekt pies:{nl}nazwa: {pies.nazwa}{nl}ilosc oczu: {pies.iloscOczu}{nl}ilosc nog: {pies.iloscNog}{nl}");
            Console.WriteLine($"Obiekt pajak:{nl}nazwa: {pajak.nazwa}{nl}ilosc oczu: {pajak.iloscOczu}{nl}ilosc nog: {pajak.iloscNog}{nl}");

            Console.ReadKey();

        }
    }
}
