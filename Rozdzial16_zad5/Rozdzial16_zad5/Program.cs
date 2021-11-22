using System;
using System.Collections.Generic;

namespace Rozdzial16_zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             5. Write a program, which removes all negative numbers from a sequence.
             Example: array = {19, -10, 12, -6, -3, 34, -2, 5} -> {19, 12, 34, 5}
             * 
             */

            /* rev 1.0
            Console.WriteLine("Input integer numbers, seperated by space");

            string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> positiveNumbers = new List<int>();

            for(int i = 0; i < numbers.Length; i++)
            {
                if(int.Parse(numbers[i]) >= 0)
                {
                    positiveNumbers.Add(int.Parse(numbers[i]));
                }
            }

            Console.WriteLine("Positive numbers from list: ");

            foreach (var num in positiveNumbers)
            {
                Console.Write("{0} ", num);
            }
            */

            // rev 2.0
            Console.WriteLine("Input integer numbers");

            List<int> sequence = new List<int>();

            while(true)
            {
                string line = Console.ReadLine();
                int number = 0;

                if(!int.TryParse(line, out number))
                {
                    break;
                }
                else
                {
                    sequence.Add(number);
                }
            }

            List<int> positiveNums = RemoveNegativeNumbers(sequence);

            foreach(var num in positiveNums)
            {
                Console.Write("{0} ", num);
            }

            Console.ReadKey();
        }

        static List<int> RemoveNegativeNumbers(List<int> seq)
        {
            List<int> result = new List<int>();

            for(int i = 0; i < seq.Count; i++)
            {
                if(seq[i] >= 0)
                {
                    result.Add(seq[i]);
                }
            }

            return result;
        }

    }
}
