using System;

namespace Rozdzial6_zad14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14. Write a program that converts a given number from decimal to hexadecimal notation.");

            Console.WriteLine("Podaj liczbe do konwersji z systemu dziesiatkowego na szesnastkowy");

            string n = Console.ReadLine();

            string toDecimal = Convert.ToString(Convert.ToInt32(n, 10), 16);

            Console.WriteLine("Wynik: {0}", toDecimal);

            Console.ReadKey();
        }
    }
}
