using System;

namespace Rozdzial6_zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program that reads from the console a positive integer number N(N < 20) and prints a matrix of numbers as on the figures below: ");

            Console.WriteLine("Podaj N (N<20)");
            int n = int.Parse(Console.ReadLine());


                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j <= i + n - 1; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }

            Console.ReadKey();
        }
    }
}
