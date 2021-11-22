using System;

namespace Rozdzial13_zad22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("22. Write a program that reads a string from the console and prints in alphabetical order all letters from the input string and how many times each one of them occurs in the string.");

            Console.WriteLine("Input word");
            string word = Console.ReadLine();
            int[] letterCounter = new int[word.Length];
            char temp;

            char[] wordArr = word.ToCharArray();

            for (int i = 1; i < wordArr.Length; i++)
            {
                for (int j = 0; j < wordArr.Length - 1; j++)
                {
                    if (wordArr[j] > wordArr[j + 1])
                    {
                        temp = wordArr[j];
                        wordArr[j] = wordArr[j + 1];
                        wordArr[j + 1] = temp;
                    }
                }
            }

            for(int i=0; i<wordArr.Length; i++)
            {
                for(int j=0; j<wordArr.Length -1; j++)
                {
                    if (wordArr[i] == wordArr[j])
                    {
                        letterCounter[i] += 1;
                    }
                }
            }

            char temp2 = wordArr[0];

            for(int i=1; i < wordArr.Length; i++)
            {
               Console.WriteLine("char {0} appears {1} times", wordArr[i], letterCounter[i]);
            }


            /* kazdy char ma jakas wartosc
            char test1 = 'a';
            char test2 = 'b';
            bool test3 = false;

            if (test1 < test2) test3 = true;

            Console.WriteLine(test3);
            */

            Console.WriteLine(wordArr);
            Console.ReadKey();
        }
    }
}
