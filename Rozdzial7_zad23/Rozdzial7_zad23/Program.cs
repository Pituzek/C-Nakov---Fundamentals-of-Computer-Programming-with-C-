using System;

namespace Rozdzial7_zad23
{
    class Program
    {

        public static int n;
        static void Main(string[] args)
        {
            Console.WriteLine("23. Write a program, which reads the integer numbers N and K from the console and prints all variations of K elements of the numbers in the interval[1…N].Example: N = 3, K = 2  { 1, 1}, { 1, 2}, { 1, 3}, { 2, 1}, { 2, 2}, { 2, 3}, { 3, 1}, { 3, 2}, { 3, 3}.");

            Console.Write("Enter N: ");
            n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr = new int[k];

            recSolution(arr, 0);
        }

        static void recSolution(int[] array, int index)
        {
            if (index != array.Length)
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    recSolution(array, index + 1);
                }
            else
            {
                for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
                Console.WriteLine();
            }
        }
        }
}
