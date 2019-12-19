#define active
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab33___LinqStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Kasia", "Matylda", "Miłosz", "WaldeMar", "Zdzisław", "Wojciech", "Jan", "Marcin", "Karol" };

#if (unactive)

            //IEnumerable<string> modifiedNames = System.Linq.Enumerable.Where(names, n => n.Length >= 7);
            IEnumerable<string> modifiedNames = names.Where(n => n.Length >= 7);

#elif (unactive)

            //IEnumerable<string> modifiedNames = from n in names
            //                                    where n.Contains("M")
            //                                    select n;

            IEnumerable<string> modifiedNames = names.Where(n => n.Contains("M"));

#elif (unactive)

            IEnumerable<string> modifiedNames = names.OrderBy(n => n);

#elif (unactive)

            IEnumerable<int> modifiedNames = names.Select(n => n.Length);

#elif (unactive)

            IEnumerable<string> filteredNames = names.Where(n => n.Contains("a"));
            IEnumerable<string> orderedNames = filteredNames.OrderBy(n => n);
            IEnumerable<string> modifiedNames = orderedNames.Select(n => n.ToUpper());

#elif (active)

            IEnumerable<string> modifiedNames = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n)
                .Select(n => n.ToUpper());

#endif

            foreach (var name in modifiedNames)
            {
                Console.Write(name + ", ");
            }

            Console.ReadKey();

        }
    }
}
