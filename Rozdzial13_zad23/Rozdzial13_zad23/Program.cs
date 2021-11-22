using System;
using System.Collections.Generic;
using System.Linq;

namespace Rozdzial13_zad23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("23. Write a program that reads a string from the console and prints in alphabetical order all words from the input string and how many times each one of them occurs in the string.");

            Dictionary<string, int> dict = new Dictionary<string, int>();

            Console.WriteLine("Input text");
            string text = Console.ReadLine();

            string[] splittedText = text.Split(" ");

            for(int i=0; i< splittedText.Length; i++)
            {
                if (dict.ContainsKey(splittedText[i]))
                {
                    int value = dict[splittedText[i]];
                    dict[splittedText[i]] = value + 1;
                }
                else
                {
                    dict.Add(splittedText[i], 1);
                }
            }

            /*
            // dictionary<klucz,wartosc> ; dict[klucz] = wartosc ; mozemy zmienic wartosc danego klucza
            Console.WriteLine(dict[splittedText[0]]);
            Console.WriteLine(dict[splittedText[0]]+=1);
            */

            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine("");
                Console.WriteLine(kvp.Key + " Counts are " + kvp.Value);  // Print the Repeated word and its count  
            }
            
            Array.Sort(splittedText);
            
            foreach (string s in splittedText)
            {
                Console.WriteLine("\n{0}", s);
                
            }

            Console.ReadKey();
        }
    }
}
