using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasyDziedziczenie
{
    class Punkt3d : Punkt2d
    {
        public int z;

        public Punkt3d(int x, int y, int z) : base (x, y)
        {
            this.z = z;
        }

        public new string PokazWspolrzedne()
        {
            return base.PokazWspolrzedne() + " " + this.z;
        }
    }
}
