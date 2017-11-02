using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Pop();
            s.Push(1);
            s.Push(2);
            s.Pop();
            s.Pop();
            s.Pop();
            s.Push(2);
            s.Pop();
            ReadInput();
            Console.ReadKey();

        }

        static void ReadInput()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            string[] testCases = new string[t];
            for (int i = 0; i < t; i++)
            {
                testCases[i] = Console.ReadLine();

            }

            foreach (string s in testCases)
            {
                string[] temp = s.Split(' ');
                Console.WriteLine(FindLargestNumber(Convert.ToInt64(temp[0]), Convert.ToInt64(temp[1]),
                              Convert.ToInt64(temp[2])
                              ));
            }
        }

        static long FindLargestNumber(long a, long b, long c)
        {

            List<int> listRemainders = new List<int>();
            for (int i = 1; i <= c; i++)
            {
                long remainder = i % a;
                if (remainder == b && remainder <= c)
                {
                    listRemainders.Add(i);
                }
            }

            return listRemainders.Count() > 0 ? listRemainders.Max() : -1;
        }
    }
}
