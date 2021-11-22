using System;

namespace Rozdzial6_zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5. Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,13, 21, 34, 55, 89, 144, 233, 377, …");

            Console.WriteLine("Podaj liczbe N");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("0, 1,");

            int pierwszyN=0, trzeciN=0, drugiN=1;

            for(int i=2; i<n; i++)
            {
                trzeciN = pierwszyN + drugiN;
                Console.Write(" {0},", trzeciN);
                pierwszyN = drugiN;
                drugiN = trzeciN;
            }

            Console.ReadKey();

        }
    }
}
