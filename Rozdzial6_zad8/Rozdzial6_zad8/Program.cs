using System;

namespace Rozdzial6_zad8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("In combinatorics, the Catalan numbers are calculated by the following formula: C=(2n)!/(n+1)!n!, for (n > 0). Write a program that calculates the nth Catalan number by given n.");
            Console.WriteLine("");
            Console.WriteLine("Podaj N (n > 0)");

            int n = Int32.Parse(Console.ReadLine());

            int dwaN = 2 * n;
            int nPlus = n + 1;

            Console.WriteLine("{0} {1} {2}", n, dwaN, nPlus);

            // for (int i = dwaN - 1; i > 0; i--) dwaN *= i;
            // for (int i = nPlus - 1; i > 0; i--) nPlus *= i;
            // for (int i = n - 1; i > 0; i--) n *= i;
           // Console.WriteLine("Wynik= {0}", (dwaN) / (nPlus * n));

            double wynikDwaN = 1, wynikNplus = 1, wynikN = 1;

            for (int i = 1; i <= dwaN; i++) wynikDwaN *= i;
                //Console.WriteLine("{0}", wynikDwaN);
            for (int i = 1; i <= nPlus; i++) wynikNplus *= i;
                //Console.WriteLine("{0}", wynikNplus);
            for (int i = 1; i <= n; i++) wynikN *= i;
                //Console.WriteLine("{0}", wynikN);
            Console.WriteLine("Wynik= {0}", (wynikDwaN) / (wynikNplus * wynikN));
            //Console.WriteLine("Wynik= {0}", (wynikDwaN) / (wynikNplus * wynikN));
            
            Console.ReadKey();
        }
    }
}
