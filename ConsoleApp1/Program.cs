using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileProcessing.CheckFileCount();
            string[] files = System.IO.Directory.GetFiles(@"C:\");
            int fileCounter = 0;
            for (int i = 0; i < files.Length; i++)
            {

                if (files.Contains(""))
                {
                    fileCounter++;
                }
            }
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6, 7 };
            int[] duplicateArr = { 1, 2, 5, 6, 7, 2, 1, 9, 5 };
            RemoveDuplicateElementsFromArray(duplicateArr).ToList().ForEach(x => Console.WriteLine(x));
            FindDuplicateElementsFromArrayWithLinq(duplicateArr).ToList().ForEach(x => Console.WriteLine(x));
            MergeArray(a, b);
            int[] c = (from r in a
                       select r).Union(
                from m in b
                select m
                ).ToArray();
            int[] d = a.Concat(b).ToArray();
            int[] e = a.Union(b).ToArray();
            int[] f = new int[a.Length + b.Length];
            Array.Copy(a, f, a.Length);
            Array.Copy(b, 0, f, a.Length, b.Length);

            SortArray(new int[5] { 5, 7, 2, 8, 1 });
            ReverseWord("Hello World");
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

        static void ReverseWord(string words)
        {
            string[] wordArary = words.Split(' ');
            for (int i = 0; i < wordArary.Length; i++)
            {
                char[] charArray = wordArary[i].ToCharArray();
                char[] newCharArray = new char[charArray.Length];
                int cntr = 0;
                string result = string.Empty;
                for (int j = charArray.Length - 1; j >= 0; j--)
                {
                    //newCharArray[cntr] = charArray[j];
                    //cntr++;
                    result += charArray[j];
                    //Console.Write(charArray[j]);

                }
                Console.WriteLine(result);
                //Console.WriteLine();
                //Console.WriteLine(string.Concat(newCharArray));
            }
        }

        static int[] SortArray(int[] array)
        {
            int length = array.Length;

            int temp = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        static int[] SortArray1(int[] array)
        {
            int temp = 0;

            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }

            return array;
        }

        static int[] MergeArray(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            for (int i = 0; i < mergedArray.Length; i++)
            {

            }
            return mergedArray;
        }

        static int[] MergeArray1(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            array1.CopyTo(mergedArray, 0);
            array2.CopyTo(mergedArray, array1.Length);
            return mergedArray;
        }

        static int[] RemoveDuplicateElementsFromArray(int[] array)
        {
            List<int> aList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!aList.Contains(array[i]))
                {
                    aList.Add(array[i]);
                }
            }
            return aList.ToArray();
        }

        static int[] RemoveDuplicate(int[] array)
        {
            int size = array.Length;

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] == array[j])
                    {
                        for (int k = j; k < size; k++)
                        {
                            array[k] = array[k + 1];
                        }
                        j--;
                        size--;
                    }
                }

            }

            return array;
        }

        static int[] RemoveDuplicateElementsFromArrayUsingLinq(int[] array)
        {
            return array.Distinct().ToArray();
        }
        static int[] FindDuplicateElementsFromArrayWithLinq(int[] array)
        {
            return array.GroupBy(i => i).Where(g => g.Count() > 1).Select(k => k.Key).ToArray();
        }

        static int[] MergeTwoSortedArray(int[] first, int[] second)
        {
            int[] result = new int[first.Length + second.Length];

            int i = 0, j = 0, k = 0;

            while (i < first.Length && j < second.Length)
            {
                if (first[i] < second[j])
                {
                    result[k++] = first[i++];
                }
                else
                {
                    result[k++] = second[j++];
                }
            }

            if (i < first.Length)
            {
                for (int a = i; a < first.Length; a++)
                    result[k] = first[a];
            }

            if (j < second.Length)
            {
                for (int a = j; a < second.Length; a++)
                    result[k++] = second[a];
            }

            return result;

        }
    }
}
