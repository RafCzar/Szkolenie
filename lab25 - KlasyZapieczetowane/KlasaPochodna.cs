using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab25___KlasyZapieczetowane
{
    class KlasaPochodna : KlasaBazowa
    {
        sealed public override void Test()
        {
            base.Test();
            Console.WriteLine("KlasaPochodna - metoda Test()");
        }
    }
}
