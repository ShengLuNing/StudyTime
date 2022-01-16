using System;
using static System.Console;

namespace QuickSort
{
    class QuickSort
    {
        ///Partition方法
        ///把数组最后一个位置的值当作基准值，去和数组中的每一个值比较（最后一个位置的值除外）
        ///找到最大值，最大值的位置为a
        ///然后把最大值与最后一个位置的值交换位置
        ///这时数组分为[0,a-1]和[a+1,max], 开始递归
        static int Partition(int[] array, int low,
                                        int high)
        {
            //1. Select a pivot point.
            int pivot = array[high];

            int lowIndex = (low - 1);

            //2. Reorder the collection.
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    lowIndex++;

                    int temp = array[lowIndex];
                    array[lowIndex] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp1;

            return lowIndex + 1;
        }

        static void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                //3. Recursively continue sorting the array
                Sort(array, low, partitionIndex - 1);
                Sort(array, partitionIndex + 1, high);
            }
        }

        public static void Main()
        {
            //生成随机数数组
            int[] array = new int[20];
            int length = array.Length;
            Random randomNum = new Random();
            for (int i = 0; i <= 19; i++)
            {
                array[i] = randomNum.Next(1000);
            }

            //打印初始数组
            foreach (int i in array)
            {
                WriteLine(i);
            }

            //快速排序
            Sort(array, 0, length - 1);//(length-1)是因为0-19就有20个数了，如果不减一就会报错IndexOutOfRange

            //打印排序后的数组
            WriteLine();
            WriteLine();
            foreach (int i in array)
            {
                WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}