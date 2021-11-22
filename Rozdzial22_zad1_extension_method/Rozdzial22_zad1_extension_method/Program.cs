using System;
using System.Text;

namespace Rozdzial22_zad1_extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Implement an extension method Substring(int index, int length)
            //for the class StringBuilder that returns a new StringBuilder and has the same functionality as
            //the method Substring(…) of the class String.

            string test = "Hello, Extension Methods!";

            int wordCount = test.WordCount();

            Console.WriteLine(wordCount);

            CountCharacters(test);

            StringBuilder sb = new StringBuilder();
            StringBuilder substringResult = new StringBuilder();
            sb.Append(test);
            substringResult.Append(sb.Substring(3, 3));
            Console.WriteLine(substringResult.ToString());
            
            


            Console.ReadKey();
        }

        static void CountCharacters(string str)
        {

            int wordCount = str.WordCount();
            string[] strArray = str.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            int[] characterCount = new int[wordCount];
            for (int i=0; i<wordCount; i++)
            {
                characterCount[i] = strArray[i].Length;
                Console.WriteLine("Word {0} has {1} characters", strArray[i], characterCount[i]);
            }

        }

    }

    public static class StringExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder s, int startIndex, int length)
        {

            StringBuilder result = new StringBuilder(s.Length);
            int iterations = startIndex + length;
            for (int i = startIndex; i < iterations; i++)
            {
                result.Append(s[i]);
            }

            return result;
        }
    }

}
