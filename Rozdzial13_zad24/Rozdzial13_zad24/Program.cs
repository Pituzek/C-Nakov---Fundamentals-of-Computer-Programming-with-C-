using System;
using System.Text;

namespace Rozdzial13_zad24
{
    class Program
    {
        static string replaceDuplicateChars(char[] c)
        {
            StringBuilder sb = new StringBuilder();

            char tmp = c[0];
            sb.Append(c[0]);

            for (int i = 1; i < c.Length; i++)
            {
                if (c[i] != tmp)
                {
                    sb.Append(c[i]);
                }

                tmp = c[i];
            }

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("24. Write a program that reads a string from the console and replaces every sequence of identical letters in it with a single letter (the repeating letter). Example: \"aaaaabbbbbcdddeeeedssaa\" -> \"abcdedsa\".");

            Console.WriteLine("Input word");
            string word = Console.ReadLine();

            char[] wordArray = word.ToCharArray();

            Console.WriteLine("\n{0}",replaceDuplicateChars(wordArray));

            Console.ReadKey();
        }
    }
}
