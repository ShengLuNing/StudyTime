using System;
using static System.Console;
using System.Collections.Generic;

namespace SelectionSort
{
    class Program
    {
        //找到数组中最小的数
        static int FindMinNum(List<int> intArr)
        {
            int smallestNum;

            smallestNum = intArr[0];
            foreach (int i in intArr)
            {
                if (i < smallestNum)
                {
                    smallestNum = i;
                }
            }

            return smallestNum;
        }

        static void Main(string[] args)
        {
            //生成随机数动态数组
            List<int> chaosArray = new List<int>(20);
            Random ranNum = new Random();
            for (int i = 0; i<=19; i++)
            {
                chaosArray.Add(ranNum.Next(1000));
            }
            
            List<int> orderArray = new List<int>();
            for (int i = 0;  i <= 19; i++)
            {
                int tempNum = FindMinNum(chaosArray);
                orderArray.Add(tempNum);
                chaosArray.Remove(tempNum);
            }

            foreach (int i in orderArray)
            {
                WriteLine(i);
            }
            
        }
    }
}