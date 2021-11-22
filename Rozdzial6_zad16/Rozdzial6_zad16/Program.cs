using System;

namespace Rozdzial6_zad16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("16. Write a program that by a given integer N prints the numbers from 1 to N in random order.");

            Console.WriteLine("Podaj liczbe N");

            int n = int.Parse(Console.ReadLine());

            var rand = new Random();

            /*
            Console.WriteLine("Five random integer values:");
            for (int ctr = 1; ctr <= n; ctr++)
                Console.WriteLine("{0}", rand.Next(1,n));
            Console.WriteLine();
            */

            int temp, randomNumber;
            //Console.Write("Enter number: ");
            //int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
            }

            Console.WriteLine("");

            //foreach (int i in arr)
            for (int i = 0; i < arr.Length; i++)
            {
                randomNumber = rand.Next(0, n);
                temp = arr[i];
                arr[i] = arr[randomNumber];
                arr[randomNumber] = temp;
            }

            //foreach (int i in arr) Console.WriteLine(arr[i]);
            
            for (int i=0; i<n;i++)
            {
                Console.WriteLine(arr[i]);
            }
            
            Console.ReadKey();
        }
    }
}
