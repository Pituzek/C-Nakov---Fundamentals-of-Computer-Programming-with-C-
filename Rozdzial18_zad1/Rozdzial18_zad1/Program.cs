using System;
using System.Collections.Generic;

namespace Rozdzial18_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program that counts, in a given array of integers, the number of occurrences of each integer.
            //Example: array = { 3, 4, 4, 2, 3, 3, 4, 3, 2}
            //2 -> 2 times 3-> 4 times 4 -> 3 times

            string sequenceInputLine = Console.ReadLine();

            SortedDictionary<int,int> numberOfOccurences = FindNumbersOccurencesCount(sequenceInputLine);

            PrintNumberOccurences(numberOfOccurences);

            Console.ReadKey();
        }

        private static SortedDictionary<int,int> FindNumbersOccurencesCount(string sequenceInputLine)
        {
            string[] tokens = sequenceInputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<int, int> numbersOfOccurenceCount = new SortedDictionary<int, int>();

            foreach (string token in tokens)
            {
                int number = int.Parse(token);
                int count;
                if ( !numbersOfOccurenceCount.TryGetValue(number, out count))
                {
                    count = 0;
                }

                numbersOfOccurenceCount[number] = count + 1;
            }

            return numbersOfOccurenceCount;
        }

        private static void PrintNumberOccurences(SortedDictionary<int,int> numberOfOccurences)
        {
            foreach (KeyValuePair<int,int> value in numberOfOccurences)
            {
                Console.WriteLine("{0} - occured {1} times", value.Key, value.Value);
            }
        }


    }
}
