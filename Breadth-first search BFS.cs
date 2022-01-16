using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;

namespace Breadth_first_search_BFS
{
    class Program
    {
        static void Search(Dictionary<string, List<string>> tu)
        {
            Queue waitQueue = new Queue(); //用来装载等待匹配的节点
            string target; 
            List<string> searched = new List<string>(); //记录已经搜索过的节点，如果已经在这个列表里，就不用找了
                                                        //同时防止无限循环
            int searchCount = 0;//用来记录搜索的次数
            //先把深度1的节点加入搜索队列
            foreach (string first in tu.Keys)
            {
                waitQueue.Enqueue(first);
            }

            while (waitQueue.Count > 0)
            {
                target = (string)waitQueue.Dequeue();
                if (!searched.Contains(target))
                {
                    if (target == "Q")
                    {
                        WriteLine($"在经历了{searchCount}次搜索后，广度优先算法成功");
                        break;
                    }
                    else
                    {
                        searched.Add(target);
                        foreach (string item in tu[target])
                        {
                            waitQueue.Enqueue(item);
                        }
                    }
                }
                searchCount++;
            }

        }

        static void Main(string[] args)
        {
            //创造一个图，好复杂，我后悔了。。。
            Dictionary<string, List<string>> name = new Dictionary<string, List<string>>();
            name.Add("A", new List<string> { "B" });
            name["A"].Add("C");
            name["A"].Add("D");
            name["A"].Add("E");
            name["A"].Add("F");

            name.Add("B", new List<string> { "H", "C" });
            name.Add("C", new List<string> { "D", "G" });
            name.Add("D", new List<string> { "N" });
            name.Add("E", new List<string> { "M", "O" });
            name.Add("F", new List<string> { "K", "L", "M" });
            name.Add("G", new List<string> { "D", "J" });
            name.Add("H", new List<string> { "J", "I" });
            name.Add("I", new List<string> { "K" });
            name.Add("J", new List<string> {  });
            name.Add("K", new List<string> { "A" });
            name.Add("L", new List<string> {  });
            name.Add("M", new List<string> {  });
            name.Add("N", new List<string> { "Q" });
            name.Add("O", new List<string> { "P" });
            name.Add("P", new List<string> { "N" });
            name.Add("Q", new List<string> { "G" });
            //最终我想在图中找到Q

            Search(name);
        }
    }
}