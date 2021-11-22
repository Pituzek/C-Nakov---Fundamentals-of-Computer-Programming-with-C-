using System;

namespace Rozdzial8_zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9. Write a program that converts a binary number to hexadecimal one.");

            Console.WriteLine("Wpisz liczbe w formacie binarnym");

            string bin = Console.ReadLine();

            Console.WriteLine("Wynik {0}", Convert.ToInt32(bin,2).ToString("X"));


            Console.ReadKey();
        }
    }
}
