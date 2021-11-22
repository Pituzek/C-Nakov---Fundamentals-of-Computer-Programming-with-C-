using System;

namespace Rozdzial9_zad10
{
    class Program
    {

        static double ObliczSilnie(double x)
        {

            double wynik = 1;

            if (x <= 1)
            {
                 wynik = 1;
            }
            else
            {
                for (int i = 1; i <= x; i++)
                {

                    wynik = wynik * i;
                    
                }
            }

            return wynik;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("10. Write a program that calculates and prints the n! for any n in the range [1…100].");

            Console.WriteLine("Wpisz liczbe n, do obliczenia n! (1-100)");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}! = {1}", n, ObliczSilnie(n));

            Console.ReadKey();
        }
    }
}
