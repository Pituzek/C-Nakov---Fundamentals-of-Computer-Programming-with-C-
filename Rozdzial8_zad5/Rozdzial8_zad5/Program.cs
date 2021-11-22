using System;

namespace Rozdzial8_zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5. Write a program that converts a binary number to decimal one.");

            Console.WriteLine("Podaj liczbe binarna do konwersji na liczbe dziesietna");
            string binary = Console.ReadLine();

            Console.WriteLine(" Wynik: {0}",Convert.ToInt32(binary, 2));

            Console.ReadKey();
        }
    }
}
