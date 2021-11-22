using System;

namespace Rozdzial10_zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9. You are given an array of positive integers. Write a program that checks whether there is one or more numbers in the array (subset), whose sum is equal to S. Can you solve the task efficiently for large arrays?");

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter sum: ");
            int sum = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int first = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int second = arr[j];

                    if ((first + second) == sum)
                        Console.WriteLine("({0}, {1}) ", first, second);
                }
            }


            Console.ReadKey();
        }
    }
}
