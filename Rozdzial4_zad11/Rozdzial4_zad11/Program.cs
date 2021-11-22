using System;

namespace Rozdzial4_zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
                11. Write a program that prints on the console the first 100 numbers 
                    in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
             * 
             */


            int fibo = 100;

            double a = 0;
            double b = 1;
            double c = 0;

            Console.Write(" {0} + {1}",a,b);

            for (int i=2;i<fibo;i++)
            {
                c = a + b;
                Console.Write(" {0}",c);
                a = b;
                b = c;
            }

            Console.ReadKey();

        }
    }
}
