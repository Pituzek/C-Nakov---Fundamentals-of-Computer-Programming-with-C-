using System;
using System.Text;

namespace Rozdzial13_zad10
{
    class Program
    {
        static string seperateSentence(string text, string s)
        {
            StringBuilder sb = new StringBuilder();
            string[] splittedText;
            splittedText = text.Split(".");

            /* debug
            foreach (string sa in splittedText)
            {
                Console.WriteLine(sa.Contains(s));
            }
            */

            for (int i=0; i < splittedText.Length; i++)
            {
                if(splittedText[i].Contains(s))
                {
                    sb.Append(splittedText[i]);
                    sb.Append('.');
                }

            }

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("10. Write a program that extracts from a text all sentences that contain a particular word. We accept that the sentences are separated from each other by the character \".\" and the words are separated from one another by a character which is not a letter. Sample text:");

            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            Console.WriteLine("\nInput word");
            string input = Console.ReadLine();

            Console.Write(seperateSentence(text, input));

            Console.ReadKey();
        }
    }
}
