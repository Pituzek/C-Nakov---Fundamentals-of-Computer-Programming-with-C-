using System;

namespace Rozdzial11_zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10. You are given a sequence of positive integer numbers given as string of numbers separated by a space. Write a program, which calculates their sum. Example: \"43 68 9 23 318\" = 461.");

            /*
             * 
            int result = 0;
            Console.Write("Enter numbers: ");
            string inputNumbers = Console.ReadLine();
            string[] splitNumbers = inputNumbers.Split(' ');

            for (int i = 0; i < splitNumbers.Length; i++)
                result += Convert.ToInt32(splitNumbers[i]);
             * 
             */

            string liczby = "43 68 9 23 318";

            string[] podzieloneLiczby = liczby.Split(" ");

            int wynik = 0;

            for (int i = 0; i < podzieloneLiczby.Length; i++)
            {
                wynik += Convert.ToInt32(podzieloneLiczby[i]);
            }


            Console.WriteLine("\nWynik: {0}", wynik);

            Console.ReadKey();
        }
    }
}
