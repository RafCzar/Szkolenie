using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab26___KlasyStatycznePola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gracz.NastepnyId);
            Console.WriteLine(Gracz.NastepnyId);

            Gracz[] gracze = new Gracz[3];
            gracze[0] = new Gracz();
            Console.WriteLine(gracze[0].Id + " " + gracze[0].Nick);

            gracze[0] = new Gracz("Player One");
            gracze[1] = new Gracz("Player Two");
            gracze[2] = new Gracz("Player Three");

            foreach (var gracz in gracze)
            {
                Console.WriteLine(gracz.Id + " " + gracz.Nick);
            }

            Console.ReadKey();
        }
    }
}
