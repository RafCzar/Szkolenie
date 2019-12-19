using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab33___LinqSingleResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 23, 48, 11, 982, 90, 111, 6, 84 };

            int firstNumber = numbers.First();
            Console.WriteLine($"firstNumber: {firstNumber}");
            int lastNumber = numbers.Last();
            Console.WriteLine($"lastNumber: {lastNumber}");
            int countNumbers = numbers.Count();
            Console.WriteLine($"countNumbers: {countNumbers}");
            int minNumber = numbers.Min();
            Console.WriteLine($"minNumber: {minNumber}");

            int secondNumber = numbers.Skip(1).First();
            Console.WriteLine($"secondNumber: {secondNumber}");

            int elementAtNumber = numbers.ElementAt(1);
            Console.WriteLine($"elementAtNumber: {elementAtNumber}");

            int secondLowest = numbers.OrderBy(r => r).Skip(1).FirstOrDefault();
            Console.WriteLine($"secondLowest: {secondLowest}");

            Console.ReadKey();
        }
    }
}
