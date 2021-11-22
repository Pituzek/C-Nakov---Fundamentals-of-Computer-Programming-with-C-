using System;
using System.Collections.Generic;

namespace Rozdzial18_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Write a program to remove from a sequence all the integers, which appear odd number of times.For instance,
            //for the sequence { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6}
            //the output would be { 5, 3, 3, 5}.
            Console.WriteLine("Hello World!");

            string input = Console.ReadLine();

            List<int> numberList;

            Dictionary<int, int> numberOccurencies = CountNumberOccurencies(input, out numberList);

            PrintOddlyOccuringNumbers(numberOccurencies, numberList);

            Console.ReadKey();
        }

        static Dictionary<int,int> CountNumberOccurencies(string input, out List<int> numberList)
        {
            string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<int, int> numberOccurenceCount = new Dictionary<int, int>();

            numberList = new List<int>();

            foreach (var token in tokens)
            {
                int number = int.Parse(token);
                int count;

                if (!numberOccurenceCount.TryGetValue(number, out count))
                {
                    count = 0;
                }

                numberOccurenceCount[number] = count + 1;
                numberList.Add(number);
            }

            return numberOccurenceCount;            
        }

        static void PrintOddlyOccuringNumbers(Dictionary<int,int> numberOccurencies, List<int> numberList)
        {

            foreach (var number in numberList)
            {
                if (numberOccurencies[number] % 2 == 0)
                {
                    int test = numberOccurencies[number];

                    Console.Write("{0} - test {1} ", number, test);
                }
            }
        }

    }
}
