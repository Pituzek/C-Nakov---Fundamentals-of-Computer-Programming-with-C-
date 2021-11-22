using System;
using System.Collections.Generic;

namespace Rozdzial16_zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            7.Write a program that finds in a given array of integers(in the range[0…1000]) how many times each of them occurs.
            Example: array = { 3, 4, 4, 2, 3, 3, 4, 3, 2}

            2 -> 2 times
            3 -> 4 times
            4 -> 3 times
            */

            List<int> sequence = new List<int>();

            while(true)
            {
                string line;
                int number = 0;
                line = Console.ReadLine();
                if(!int.TryParse(line, out number))
                {
                    break;
                }
                else
                {
                    sequence.Add(int.Parse(line));
                }

            }

            int[] numberOfTimes = new int[1001];

            foreach(var num in sequence)
            {
                numberOfTimes[num]++;
            }

            for(int i = 0; i < numberOfTimes.Length; i++)
            {
                if(numberOfTimes[i] != 0)
                {
                    Console.WriteLine("{0} - {1} times", i, numberOfTimes[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
