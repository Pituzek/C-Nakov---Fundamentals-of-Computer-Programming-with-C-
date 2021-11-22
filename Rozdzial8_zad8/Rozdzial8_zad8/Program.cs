using System;

namespace Rozdzial8_zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8. Write a program that converts a hexadecimal number to binary one.");

            Console.WriteLine("Podaj liczbe w formacie hex");

            string hex = Console.ReadLine();

            Console.WriteLine("Wynik: {0}", Convert.ToString(Convert.ToInt32(hex, 16),2));

            Console.ReadKey();
        }
    }
}
