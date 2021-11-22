using System;


namespace Rozdzial11_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Write a program, which reads from the console a year and checks if it is a leap year.");

            Console.WriteLine("\nPodaj rok");

            int rok = int.Parse(Console.ReadLine());

            bool przestepny = DateTime.IsLeapYear(rok);

            if(przestepny == true) Console.WriteLine("\nRok {0}, jest rokiem przestępnym", rok);
            else Console.WriteLine("\nRok {0}, nie jest rokiem przestępnym", rok);

            Console.ReadKey();
        }
    }
}
