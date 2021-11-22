using System;

namespace Rozdzial7_zad21
{
    class Program
    {

        public static int[] findSolution(int[] a, bool[] filter, int index, int s, int size)
        {
            if (index < a.Length)
            {
                filter[index] = true;
                int[] x = findSolution(a, filter, index + 1, s, size);

                if (x.Length > 0) return x;
                else
                {
                    filter[index] = false;
                    return findSolution(a, filter, index + 1, s, size);
                }
            }
            else
            {
                int sum = 0, count = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (filter[i])
                    {
                        sum += a[i];
                        count++;
                    }
                }

                int[] solution = new int[0];

                if (sum == s && count == size)
                {
                    solution = new int[count];
                    count = 0;

                    for (int i = 0; i < a.Length; i++) if (filter[i]) solution[count++] = a[i];
                }
                return solution;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("21. Write a program which by given N numbers, K and S, finds K elements out of the N numbers, the sum of which is exactly S or says it is not possible. Example: { 3, 1, 2, 4, 9, 6}, S = 14, K = 3  yes(1 + 2 + 4 = 14)");

            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter K = ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Sum of elements, s = ");
            int s = int.Parse(Console.ReadLine());

            int[] solution = findSolution(arr, new bool[arr.Length], 0, s, size);

            Console.WriteLine("Your solution:");
            for (int i = 0; i < solution.Length; i++) Console.Write(solution[i] + "; ");
            Console.ReadLine();





            Console.ReadKey();
        }
    }
}
