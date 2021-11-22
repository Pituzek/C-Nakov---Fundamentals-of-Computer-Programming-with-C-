using System;
using System.Text;

namespace Rozdzial13_zad11
{
    class Program
    {
        static string censorship(string s, string[] forbidW)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(s);

            int index = 0;

            for (int i = 0; i < forbidW.Length; i++)
            {
                index = s.IndexOf(forbidW[i]);

                while (index != -1)
                {
                    //debug
                    //Console.WriteLine("{0} found at index: {1}", forbidW[i], index);

                    string check = forbidW[i];
                    int len = check.Length;

                    for (int j = 0; j < len; j++)
                    {
                        sb[index+j] = '*';
                    }

                    index = s.IndexOf(forbidW[i], index + 1);
                }
            }
 
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("11. A string is given, composed of several \"forbidden\" words separated by commas. Also a text is given, containing those words. Write a program that replaces the forbidden words with asterisks. Sample text:");

            string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";
            string forbiddenWords = "C#,CLR,Microsoft";

            string[] forbidW = forbiddenWords.Split(',');

            string value = censorship(text, forbidW);

            Console.WriteLine("\n{0}",value);

            Console.ReadKey();
        }
    }
}
