using System;
using System.Collections.Generic;

namespace Rozdzial13_zad15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("15. A dictionary is given, which consists of several lines of text. Each line consists of a word and its explanation, separated by a hyphen:");
            /*
             * 
             .NET – platform for applications from Microsoft
             CLR – managed execution environment for .NET
             namespace – hierarchical organization of classes
             *
             *
             Write a program that parses the dictionary and then reads words 
             from the console in a loop, gives an explanation for it or writes 
             a message on the console that the word is not into the dictionary.
             *
             */

            //https://www.tutorialsteacher.com/csharp/csharp-dictionary

            //mozna bylo dodac wpisywanie informacji na poczatku, a potem string.Split poprzez nowa spacje, a potem poprzez znak " - "
            //na koncu dodac wartosci do dictionary przez .add

            IDictionary<string, string> names = new Dictionary<string, string>()
            {
                {".NET", "- platform for applications from Microsoft"},
                { "CLR", "- managed execution environment for .NET" },
                {"namespace", "- hierarchical organization of classes"},
            };

            string exit = "n";

            while (exit == "n")
            {
                Console.Clear();
                Console.WriteLine("\nType in a word for search (CLR, .NET, namespace)");
                string search = Console.ReadLine();

                if (names.ContainsKey(search))
                {
                    Console.WriteLine("\nMeans: {0}",names[search]);
                }
                else
                {
                    Console.WriteLine("\nThe word isn't in the dictionary");
                }

                Console.WriteLine("\nExit? Y/N");
                exit = Console.ReadLine().ToLower();
            }

            Console.ReadKey();
        }
    }
}
