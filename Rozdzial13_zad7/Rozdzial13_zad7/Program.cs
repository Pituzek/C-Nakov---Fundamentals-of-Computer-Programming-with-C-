using System;
using System.Text;

namespace Rozdzial13_zad7
{
    class Program
    {
        static string replaceInput(int n, string s)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(s);

            for (int i=0; i < n; i++)
            {
                sb.Append('*');
            }

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("7. Write a program that reads a string from the console (20 characters maximum) and if shorter complements it right with \" * \" to 20 characters.");

            Console.WriteLine("\nWpisz tekst (max 20 znaków)");
            string input = Console.ReadLine();
            string output = string.Empty;

            int inputLength = input.Length;
            int numberOfStars = 0, maxChars = 20;

            if (inputLength < 20)
            {
                numberOfStars = maxChars - inputLength;
                output = replaceInput(numberOfStars, input);
            } 
            else
            {
                output = input;
            }
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
