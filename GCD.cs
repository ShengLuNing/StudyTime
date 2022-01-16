using System;
using static System.Console;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4851;
            int b = 3003;
            int remainder;

            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }
            WriteLine(a);
        }
    }
}
