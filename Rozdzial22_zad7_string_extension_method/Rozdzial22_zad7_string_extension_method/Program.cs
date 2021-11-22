using System;
using System.Text;

namespace Rozdzial22_zad7_string_extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Write an extension method for the class String that capitalizes all letters,
            //which are the beginning of a word in a sentence in English.
            //For example: "this iS a Sample sentence." should be converted to "This Is A Sample Sentence.".

            string text = "this iS a Sample sentence.";

            Console.WriteLine(StringExt.ToTitleCase(text));

            Console.ReadKey();
        }
    }

    public static class StringExt
    {
        private static bool IsLetterOrDigitExt(string s, int index)
        {
            return !IsAtStringBoundaries(s, index) && char.IsLetterOrDigit(s[index]);
        }

        private static bool IsWordSeparator(string s, int index)
        {
            if (!IsAtStringBoundaries(s, index))
            {
                if (s[index] == '\'' && IsLetterOrDigitExt(s, index - 1))
                {
                    return false;
                }
                else
                {
                    return !IsLetterOrDigitExt(s, index);
                }
            }
            else
            {
                return true;
            }
        }

        private static bool IsAtStringBoundaries(string s, int index)
        {
            return index == -1 || index == s.Length;
        }

        public static string ToTitleCase(this string s)
        {
            StringBuilder output = new StringBuilder(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                output.Append(IsWordSeparator(s, i - 1) ? char.ToUpper(s[i]) : char.ToLower(s[i]));
            }

            return output.ToString();
        }

    }

}
