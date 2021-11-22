using System;

namespace Rozdzial8_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. Write a program that converts a decimal number to binary one.");

            Console.WriteLine("Wpisz liczbe typu dziesietnego");
            int liczba = int.Parse(Console.ReadLine());

            Console.WriteLine("Liczba {0}, w systemie bianarnym wynosi: {1}",liczba ,Convert.ToString(liczba, 2));


            Console.ReadKey();
        }
    }
}
