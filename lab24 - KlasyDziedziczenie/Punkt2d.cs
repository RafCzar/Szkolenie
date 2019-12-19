using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasyDziedziczenie
{
    class Punkt2d
    {
        public int x;
        public int y;

        public Punkt2d(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string PokazWspolrzedne()
        {
            return $"{x} {y}";
        }

    }
}
