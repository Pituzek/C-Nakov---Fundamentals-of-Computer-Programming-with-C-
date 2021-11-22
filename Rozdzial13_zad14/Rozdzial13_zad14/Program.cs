using System;
using System.Text;

namespace Rozdzial13_zad14
{
    class Program
    {
        static string reverseText(string t)
        {
            StringBuilder sb = new StringBuilder();
            char[] seperators = { ',', ' ', '.'};
            string[] words = t.Split(seperators);
            
            for (int i = words.Length - 1; i >=0; i--)
            {
                if (words[i] != "") //dodawalo mi spacje do tablicy zamiast kropki, przez co "." miala potem zla pozycje
                {
                    sb.Append(words[i]);
                    sb.Append(' ');
                }
            }
            
            for (int i=0; i<t.Length; i++)
            {
                if (t[i] == '.')
                {
                    sb.Insert(i, '.');
                }

                if (t[i] == ',')
                {
                    sb.Insert(i, ',');
                }
            }

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("14. Write a program that reverses the words in a given sentence without changing punctuation and spaces. For example: \"C# is not C++ and PHP is not Delphi\"  \"Delphi not is PHP and C++ not is C#\".");

            string text = "C# is not C++, and PHP is not Delphi.";
            string reverse = reverseText(text);

            Console.WriteLine(reverse);

            Console.ReadKey();
        }
    }
}
