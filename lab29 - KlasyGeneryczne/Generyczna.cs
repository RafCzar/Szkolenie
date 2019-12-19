using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab29___KlasyGeneryczne
{
    class Generyczna<COKOLWIEK>
    {
        COKOLWIEK nazwaZmiennejTypuGenerycznego;

        public COKOLWIEK ZwrocWartosc()
        {
            return nazwaZmiennejTypuGenerycznego;
        }

        public void NadajWartosc(COKOLWIEK nazParTypGen)
        {
            nazwaZmiennejTypuGenerycznego = nazParTypGen;
        }
    }
}
