#define przyklad3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15___TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

#if (przyklad1)

			try
			{
				Console.WriteLine("Podaj bok kwadratu");
				int number = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine($"Pole kwadratu: {number * number}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Błednie wprowadzona liczba {ex.Message}");
			}
			finally 
			{
				Console.WriteLine("Program Koniec");
			}

#elif (przyklad2)

			try
			{
				int liczba1 = 4;
				int liczba2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(liczba1 / liczba2);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Error - DivideByZeroException");
			}
			catch (Exception)
			{
				Console.WriteLine("Error - Exception");
			}

#elif (przyklad3)

            try
            {
                int liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba <= 0)
                {
                    throw new ArgumentException("wartosc nie moze byc ujemna ani rowna zeru");
                }
            }
            catch (Exception ex)
            {
				Console.WriteLine(ex.Message);
            }


#endif

            Console.ReadKey();
        }
    }
}
