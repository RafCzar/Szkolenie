using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasyDziedziczenieMetodyWirtualne
{
    class Punkt3d : Punkt2d
    {
        public int z;

        public Punkt3d(int x, int y, int z) : base (x, y)
        {
            this.z = z;
        }

        override public string PokazWspolrzedne()
        {
            return this.x + " " + this.y + " " + this.z;
        }
    }
}
