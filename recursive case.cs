using System;
using static System.Console;

namespace Recursion
{
    class Program
    {
        static int RecursionMethod(int inputNum)
        {
            if (inputNum == 0)
            {
                return 1;
            }
            return inputNum * RecursionMethod(inputNum - 1);
        }

        static void Main(string[] args)
        {
            int a = 10;
            WriteLine(RecursionMethod(a));
        }
    }
}