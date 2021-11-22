using System;

namespace Rozdzial6_zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6. Write a program that calculates N!/K! for given N and K (1<K<N).");

            Console.WriteLine("Podaj N!");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj K!");
            int k = Int32.Parse(Console.ReadLine());

            int n2 = n;
            int k2 = k;

            for (int i=n-1; i > 0 ; i--)
            {
                n *= i;
                Console.Write(n + " ");
            }

            Console.WriteLine();

            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
                Console.Write(k+" ");
            }

            Console.WriteLine();

            int wynikN2 = 1;
            int wynikK2 = 1;

            for (int i = 1; i <= n2; i++)
            {
                wynikN2 *= i;
                Console.Write(wynikN2 + " ");
            }

            Console.WriteLine();

            for (int i = 1; i <= k2; i++)
            {
                wynikK2 *= i;
                Console.Write(wynikK2 + " ");
            }

            Console.WriteLine();

            n /= k;
            Console.WriteLine("Result is {0}", n);

            Console.WriteLine();

            wynikN2 /= wynikK2;
            Console.WriteLine("Result is {0}", wynikN2);

            Console.ReadKey();
        }
    }
}
