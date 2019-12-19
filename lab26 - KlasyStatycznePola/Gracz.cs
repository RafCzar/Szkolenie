using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab26___KlasyStatycznePola
{
    class Gracz
    {
        public string Nick { get; set; }
        public int Id { get; }
        public static int NastepnyId { get; set; }

        public Gracz()
        {
            Console.WriteLine("domyslny konstruktor Gracza");
            Nick = null;
            Id = -10;
        }

        public Gracz(string nick)
        {
            Nick = nick;
            NastepnyId++;
            Id = NastepnyId;
        }


    }
}
