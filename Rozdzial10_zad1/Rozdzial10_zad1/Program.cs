using System;

namespace Rozdzial10_zad1
{
    class Program
    {
        static void Petla(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                foreach (int element in arr) Console.Write("{0} ", element);
                Console.WriteLine();
            }
            else
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    Petla(arr, index + 1);
                }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. Write a program to simulate n nested loops from 1 to n.");

            Console.WriteLine("\nPodaj n");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Petla(arr, 0);

            Console.ReadKey();
        }
    }
}
