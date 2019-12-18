using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08___TypEnum
{
    class Program
    {
        enum State
        {
            On,
            Off = 11,
            Unknown = 11
        }
        static void Main(string[] args)
        {
            State state = State.Off;

            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state++;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");
            state--;
            Console.WriteLine($"Stan: {state} , wartosc: {Convert.ToInt32(state)}");

            Console.ReadKey();
        }
    }
}
