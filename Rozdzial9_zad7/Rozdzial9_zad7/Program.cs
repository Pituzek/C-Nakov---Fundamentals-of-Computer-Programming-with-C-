using System;

namespace Rozdzial9_zad7
{
    class Program
    {
        public static string Reverse(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("7. Write a method that prints the digits of a given decimal number in a reversed order. For example 256, must be printed as 652.");

            Console.Write("Enter number: ");
            string number = Console.ReadLine();

            Console.WriteLine(Reverse(number));

            Console.ReadKey();
        }
    }
}
