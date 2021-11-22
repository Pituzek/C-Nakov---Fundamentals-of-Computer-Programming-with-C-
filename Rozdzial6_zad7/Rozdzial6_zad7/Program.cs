using System;

namespace Rozdzial6_zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7. Write a program that calculates N!*K!/(N-K)! for given N and K(1 < K < N).");

            Console.WriteLine("Podaj N (1 < K < N)");
                int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj K (1 < K < N)");
                int k = Int32.Parse(Console.ReadLine());

                int nMinusK = n - k;

                //Console.WriteLine("{0} {1} {2}", n, k, nMinusK);
            
            for (int i = n - 1; i > 0; i--) n *= i;
                //Console.WriteLine("{0}", n);
            for (int i = k - 1; i > 0; i--) k *= i;
                //Console.WriteLine("{0}", k);
            for (int i = nMinusK-1; i > 0; i--) nMinusK *= i;
                //Console.WriteLine("{0} ", nMinusK);

            Console.WriteLine("Wynik: {0}", n * k / nMinusK);

            Console.ReadKey();

        }
    }
}
