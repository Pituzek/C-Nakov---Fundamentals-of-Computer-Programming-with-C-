using System;

namespace Rozdzial13_zad12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12. Write a program that reads a number from console and prints it in 15-character field, aligned right in several ways: as a decimal number, hexadecimal number, percentage, currency and exponential (scientific) notation.");

            Console.WriteLine("\nInput number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\n{0,15:D}\n{0,15:X}\n{0,15:P}\n{0,15:C}\n{0,15:E}", number);


            Console.ReadKey();
        }
    }
}
