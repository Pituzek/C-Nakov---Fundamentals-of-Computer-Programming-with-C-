using System;
using System.Text;

namespace Rozdzial13_zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8. Write a program that converts a given string into the form of array of Unicode escape sequences in the format used in the C# language. Sample input: \"Test\". Result: \"\u0054\u0065\u0073\u0074\".");

            var str = "Test";
            char c;

            for (int i=0; i < str.Length; i++)
            {
                c = str[i];
                ushort cOut = Convert.ToUInt16(c);
                Console.Write("\\u{0:x4} ", cOut);
            }

            Console.ReadKey();
        }
    }
}
