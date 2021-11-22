using System;

namespace Rozdzial6_zad12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12. Write a program that converts a given number from decimal to binary notation(numeral system).");

            Console.WriteLine("Wprowadz liczbe do konwersji na system binarny");
            int liczba = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(liczba, 2);
            Console.WriteLine("Result is {0}", binary);


            Console.ReadKey();        
        }
    }
}
