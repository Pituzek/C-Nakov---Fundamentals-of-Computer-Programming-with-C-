using System;
using System.Collections.Generic;
using System.Linq;

namespace Rozdzial16_zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             6. Write a program that removes from a given sequence all numbers that appear an odd count of times.
             Example: array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}
             * 
             */

            Console.WriteLine("Input numbers");

            List<int> sequence = new List<int>();

            while(true)
            {
                string line;
                int number = 0;
                line = Console.ReadLine();

                if (!int.TryParse(line, out number))
                {
                    break;
                }
                else
                {
                    sequence.Add(int.Parse(line));
                }
            }

            List<int> oddNumbersRemoved = RemoveOddNumbers(sequence);

            foreach(var num in oddNumbersRemoved)
            {
                Console.Write("{0} ", num);
            }


            Console.ReadKey();
        }

        static List<int> RemoveOddNumbers(List<int> seq)
        {

            if(seq.Count == 0)
            {
                return seq;
            }

            List<int> orderedSeq = seq.OrderBy(x => x).ToList();
            List<int> toBeRemoved = new List<int>();

            int currentCount = 1;

            for(int i = 0; i < seq.Count - 1; i++)
            {
                if(orderedSeq[i] != orderedSeq[i+1])
                {
                    if(currentCount % 2 != 0)
                    {
                        toBeRemoved.Add(orderedSeq[i]);
                    }

                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                    if(i == orderedSeq.Count - 2)
                    {
                        if (currentCount % 2 != 0)
                        {
                            toBeRemoved.Add(orderedSeq[i]);
                        }
                    }
                }
            }

            List<int> result = new List<int>();

            for(int i = 0; i < seq.Count; i++)
            {
                if(!toBeRemoved.Contains(seq[i]))
                {
                    result.Add(seq[i]);
                }
            }

            return result;
        }
    }
}
