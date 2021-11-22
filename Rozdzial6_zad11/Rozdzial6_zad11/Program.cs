using System;

namespace Rozdzial6_zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program that calculates with how many zeroes the factorial of a given number ends.Examples:");
            Console.WriteLine("N = 10->N! = 3628800-> 2");
            Console.WriteLine("N = 20->N! = 2432902008176640000-> 4");

            Console.WriteLine("Podaj N!");
            int n = int.Parse(Console.ReadLine());
            int zera = 0;
            int wynik = 1;

            for(int i= 1; i <= n; i++)
            {
                wynik *= i;
            }

            if (wynik % 10 == 0)
            {
                do
                {
                    wynik /= 10;
                    zera++;

                } while (wynik % 10 == 0);
            }

            Console.WriteLine(zera);

            Console.ReadKey();
        }
    }
}
