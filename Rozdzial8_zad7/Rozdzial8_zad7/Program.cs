using System;

namespace Rozdzial8_zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7. Write a program that converts a hexadecimal number to decimal one.");

            Console.WriteLine("Podaj liczbe w formacie hex");

            string hex = Console.ReadLine();

            Console.WriteLine("Wynik: {0}", Convert.ToInt32(hex, 16));



            Console.ReadKey();
        }
    }
}
