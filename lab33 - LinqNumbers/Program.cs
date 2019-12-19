#define active
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab33___LinqNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 23, 48, 11, 982, 90, 111, 6, 84 };

#if (unactive)

            IEnumerable<int> modifiedNumbers = numbers.Take(3);

#elif(unactive)

            IEnumerable<int> modifiedNumbers = numbers.Skip(3);

#elif(active)

            IEnumerable<int> modifiedNumbers = numbers.Reverse();

#endif

            foreach (var number in modifiedNumbers)
            {
                Console.Write(number + ", ");
            }

            Console.ReadKey();

        }
    }
}
