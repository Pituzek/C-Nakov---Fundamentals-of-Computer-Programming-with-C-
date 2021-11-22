using System;

namespace Rozdzial10_zad3
{
    class Program
    {

        static void GetCombinations(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write("{0} ", arr[i]);
                    else Console.Write(arr[i]);
                Console.Write("), ");
            }
            else
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GetCombinations(arr, index + 1, i, end);
                }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program to generate and print all combinations with duplicates of k elements from a set with n elements. Sample input:");

            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = Int32.Parse(Console.ReadLine());
            int[] arr = new int[k];
            GetCombinations(arr, 0, 1, n);

            Console.ReadKey();
        }
    }
}
