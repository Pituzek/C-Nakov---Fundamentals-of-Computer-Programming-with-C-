using System;
using System.Collections;
using System.Text;

namespace Rozdzial13_zad2
{
    class Program
    {
        static string Odwroc(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("2. Write a program that reads a string, reverse it and prints it to the console. For example: \"introduction\"  \"noitcudortni\".");

            Console.WriteLine("\nWpisz tekst do odwrocenia");
            string text = Console.ReadLine();
            string reverseText = Odwroc(text);
            Console.WriteLine("\n{0}", reverseText);

            Console.ReadKey();
        }
    }
}
