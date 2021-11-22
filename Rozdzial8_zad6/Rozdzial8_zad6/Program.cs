using System;

namespace Rozdzial8_zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6. Write a program that converts a decimal number to hexadecimal one.");

            Console.WriteLine("Wpisz liczbe dziesietna");

            int liczba = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Wynik: {0}", liczba.ToString("X"));


            Console.ReadKey();
        }
    }
}
