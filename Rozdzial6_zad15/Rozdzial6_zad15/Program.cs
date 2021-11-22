using System;

namespace Rozdzial6_zad15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("15. Write a program that converts a given number from hexadecimal to decimal notation.");

            Console.WriteLine("Wpisz liczbę szesnastkową");
            string n = Console.ReadLine();

            string toHexa = Convert.ToString(Convert.ToInt32(n, 16), 10);

            Console.WriteLine("Wynik: {0}", toHexa);


            Console.ReadKey();
        }
    }
}
