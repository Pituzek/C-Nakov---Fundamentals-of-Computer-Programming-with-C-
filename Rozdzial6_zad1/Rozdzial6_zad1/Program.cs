using System;

namespace Rozdzial6_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Write a program that prints on the console the numbers from 1 to N. 
             * The number N should be read from the standard input.
             */

            Console.WriteLine("Podaj zakres liczb N");

            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
