using System;

namespace Rozdzial6_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2. Write a program that prints on the console the numbers from 1 to N,
             * which are not divisible by 3 and 7 simultaneously.
             * The number N should be read from the standard input.
             */

            Console.WriteLine("Podaj zakres liczb N");
            int n = int.Parse(Console.ReadLine());

            for (int i=1;i<=n;i++)
            {
                if (i % (3 * 7) != 0)
                {
                    Console.WriteLine(i);
                }


            }
            Console.ReadKey();
        }
    }
}
