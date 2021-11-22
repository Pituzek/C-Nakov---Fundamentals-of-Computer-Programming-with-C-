using System;

namespace Rozdzial6_zad13
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("13. Write a program that converts a given number from binary to decimal notation.");

            Console.Write("Enter binary number: ");
            
            string n = Console.ReadLine();

            string toDecimal = Convert.ToString(Convert.ToInt32(n,2), 10);

            Console.WriteLine("Result is {0}", toDecimal);

            Console.ReadKey();
        }
    }
}
