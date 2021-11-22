using System;
using System.Collections.Generic;

namespace Rozdzial16_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. Write a method that finds the longest subsequence of equal numbers in a given List<int> and returns the result as new List<int>." +
                " Write a program to test whether the method works correctly.");

            Console.WriteLine("Add elements to list");
            List<int> nums = new List<int>();

            string s;
            while((s = Console.ReadLine()) != "")
            {
                nums.Add(int.Parse(s));
            }

            Console.Clear();

            nums = findLongestSequence(nums);

            foreach(var numbers in nums)
            {
                Console.Write("{0} ", numbers);
            }

            Console.ReadKey();
        }

        static List<int> findLongestSequence(List<int> sequence)
        {
            List<int> currentSeq = new List<int>();
            List<int> bestSeq = new List<int>();

            sequence.Sort();

            currentSeq.Add(sequence[0]);
            bestSeq.Add(sequence[0]);

            for (int i = 1; i < sequence.Count; i++)
            {
                int current = sequence[i];

                if (current == currentSeq[0])
                {
                    currentSeq.Add(current);
                }
                else
                {
                    if(currentSeq.Count > bestSeq.Count)
                    {
                        bestSeq = currentSeq;
                    }
                    else
                    {
                        currentSeq = new List<int>();
                        currentSeq.Add(current);
                    }
                }
            }

            if(currentSeq.Count > bestSeq.Count)
            {
                bestSeq = currentSeq;
            }

            return bestSeq;
        }

    }
}
