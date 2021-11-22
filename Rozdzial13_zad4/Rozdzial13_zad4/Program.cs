using System;

namespace Rozdzial13_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. How many backslashes you must specify as an argument to the method Split(…) in order to split the text by a backslash? Example: one\\two\\three.");
            //Note: In C# backslash is an escaping character.

            string backslashSplit = "one\\two\\three";
            string[] tab = backslashSplit.Split('\\');

            foreach (string s in tab)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
