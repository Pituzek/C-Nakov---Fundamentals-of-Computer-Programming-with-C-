using System;

namespace Rozdzial7_zad22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("22. Write a program, which reads an array of integer numbers from the console and removes a minimal number of elements in such a way that the remaining array is sorted in an increasing order. Example: { 6, 1, 4, 3, 0, 3, 6, 4, 5}  { 1, 3, 3, 4, 5}");

            int subset = 0, longestLength = 0;

            Console.Write("Enter arr length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int m = (1 << length);
            int[,] subsets = new int[m, length];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < length; j++) subsets[i, j] = i / (m / 2 / (1 << j)) % 2;

            for (int i = 0; i < m; i++)
            {
                int max = -1000, count = 0;

                for (int j = 0; j < length; j++)
                {
                    if (subsets[i, j] > 0)
                    {
                        if (arr[j] >= max)
                        {
                            count++;
                            max = arr[j];
                        }
                        else
                        {
                            count = 0;
                            break;
                        }
                    }
                }

                if (longestLength < count)
                {
                    longestLength = count;
                    subset = i;
                }
            }

            Console.WriteLine("Result:");
            for (int i = 0; i < length; i++) if (subsets[subset, i] > 0) Console.Write(arr[i] + "; ");


            Console.ReadKey();
        }
    }
}
