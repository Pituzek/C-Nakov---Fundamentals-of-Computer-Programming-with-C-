using System;

namespace Rozdzial7_zad20
{
    class Program
    {

        static int wantedSum;
        static bool solution = false;

        static void GenerateSubset(int[] arr, int[] subset, int index, int current, int elementsInSubset)
        {
            if (index == elementsInSubset)
            {
                CheckSubsets(subset, elementsInSubset);
                return;
            }

            for (int i = current; i < arr.Length; i++)
            {
                subset[index] = arr[i];
                GenerateSubset(arr, subset, index + 1, i + 1, elementsInSubset);
            }
        }

        static void CheckSubsets(int[] subset, int elementsInSubset)
        {
            int sum = 0;

            for (int i = 0; i < elementsInSubset; i++) sum += subset[i];

            if (sum == wantedSum)
            {
                for (int i = 0; i < elementsInSubset; i++) Console.Write("{0} ", subset[i]);

                Console.WriteLine();
                solution = true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("20. * Write a program, which checks whether there is a subset of given array of N elements, which has a sum S.The numbers N, S and the array values are read from the console.Same number can be used many times. Example: { 2, 1, 2, 4, 3, 5, 2, 6}, S = 14  yes(1 + 2 + 5 + 6 = 14)");

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter S: ");
            wantedSum = int.Parse(Console.ReadLine());

            int[] subset = new int[length];

            for (int i = 1; i <= length; i++) GenerateSubset(arr, subset, 0, 0, i);

            if (!solution) Console.WriteLine("No subset with sum {0} found.", wantedSum);

            Console.ReadKey();
        }
    }
}
