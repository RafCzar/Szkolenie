using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08___TypEnumSwitch
{
    class Program
    {
        enum State
        {
            On,
            Off,
            Unknown
        }
        static void Main(string[] args)
        {
            State state = State.Off;

            switch (state)
            {
                case State.On:
                    Console.WriteLine("włączony");
                    break;
                case State.Off:
                    Console.WriteLine("wyłączony");
                    break;
                case State.Unknown:
                    Console.WriteLine("nieznany");
                    break;
                default:
                    break;
            }

        }
    }
}
