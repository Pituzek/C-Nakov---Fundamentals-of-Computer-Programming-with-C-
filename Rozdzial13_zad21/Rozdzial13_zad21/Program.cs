using System;

namespace Rozdzial13_zad21
{
    class Program
    {
        public static string reverseText(string text)
       {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            return reverse;
       }

        public static void findPalindromes(string[] text, bool[] palindrome)
        {

            Console.WriteLine("");

            for (int i = 0; i < text.Length; i++)
            {
                if (palindrome[i] == true)
                {
                    Console.WriteLine("{0} is a palindrome", text[i]);
                }
                else
                {
                    Console.WriteLine("{0} isn't a palindrome", text[i]);
                }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("21. Write a program that extracts from a text all words which are palindromes, such as ABBA\", \"lamal\", \"exe\".");

            Console.WriteLine("\nInput text, to find palindromes");
            string text = Console.ReadLine();
            string[] textArray = text.Split(" ");
            string[] reverseTextArray = new string[textArray.Length];
            bool[] isPalindrome = new bool[textArray.Length];

            for (int i = 0; i < textArray.Length; i++)
            {
                reverseTextArray[i] = reverseText(textArray[i]);
                //Console.WriteLine(palindromes[i]);
                if (textArray[i] == reverseTextArray[i]) isPalindrome[i] = true;
            }

            findPalindromes(textArray, isPalindrome);

            Console.ReadKey();
        }
    }
}
