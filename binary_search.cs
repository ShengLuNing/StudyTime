using System;
using static System.Console;

namespace Binary_Search
{
    class Program
    {
        static int Search(int[] intList, int target)
        {
            int mid = 0;
            int low = 0;
            int high = intList.Length - 1;

            while (low <= high)
            {
                mid = (low + high) / 2;
                int guess = intList[mid];
                if (guess == target)
                {
                    return mid;
                }
                else if (guess >= target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return mid;
        }

        static void Main(string[] args)
        {
            int[] intList = new int[10] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            WriteLine(Search(intList, 3));

        }
    }
}