using System;

namespace Rozdzial6_zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9. Write a program that for a given integers n and x, calculates the sum: S=1+1!/x+2!/X^2+...+n!/x^n");
/*
            Console.WriteLine("Podaj n");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj x");
            int x = Int32.Parse(Console.ReadLine());
*/
                double sum = 1, temp = 1;
            Console.Write("Enter n: ");
                double n = double.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
                double x = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                temp *= i / x;
                sum += temp;
            }

            Console.WriteLine("Result is {0}", sum);

            Console.ReadKey();
        }
    }
}
