using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Rozdzial18_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Write a program that counts how many times each word from a given text file words.txt appears in it.
            //The result words should be ordered by their number of occurrences in the text.
            //Example: "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?"
            //Result: is -> 2, the -> 2, this -> 3, text -> 6.

            string inputText = Console.ReadLine();

            Dictionary<string, int> wordOccurenceCount = new Dictionary<string, int>();

            wordOccurenceCount = WordOccurenceCount(wordOccurenceCount, inputText);

            PrintWordOccurenceCount(wordOccurenceCount);

            Console.ReadKey();
        }

        private static Dictionary<string,int> WordOccurenceCount(Dictionary<string,int> wordOccurenceCount, string inputText)
        {
            bool test = true;

            while (test)
            {
                string[] tokens = inputText.Split(new char[] { ' ', ',', '.', ':', ';', '-','?','!' }, StringSplitOptions.RemoveEmptyEntries);
                int count;

                foreach (string word in tokens)
                {
                    string wordToLower = word.ToLower();

                    if (!wordOccurenceCount.TryGetValue(wordToLower, out count))
                    {
                        count = 0;
                    }
                    wordOccurenceCount[wordToLower] = count + 1;
                }

                test = false;
            }

            return wordOccurenceCount;
        }

        private static void PrintWordOccurenceCount(Dictionary<string,int> wordOccurenceCount)
        {
            var sorted = wordOccurenceCount.OrderBy(p => p.Value);

            Console.WriteLine();

            foreach (KeyValuePair<string,int> word in sorted)
            {
                Console.Write("Word: {0}, count: {1}\n", word.Key, word.Value);
            }
        }

    }
}
