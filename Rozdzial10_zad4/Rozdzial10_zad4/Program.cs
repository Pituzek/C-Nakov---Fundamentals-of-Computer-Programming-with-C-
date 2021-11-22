using System;

namespace Rozdzial10_zad4
{
    class Program
    {
        static string[] wordsArr = { "test", "rock", "fun" };
        static void Wypisz(int[] arr, int index, int start, int end)
        {

            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0}", wordsArr[arr[i]]);
                    if (i != arr.Length - 1) Console.Write(" ");
                }
                Console.Write("), ");
            }
            else
                for (int i = start; i < end; i++)
                {
                    arr[index] = i;
                    Wypisz(arr, index + 1, i + 1, end);
                }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("You are given a set of strings. Write a recursive program, which generates all subsets, consisting exactly k strings chosen among the elements of this set. Sample input:");
          
            /* strings = { 'test', 'rock', 'fun'}
             k = 2
             Sample output:
             (test rock), (test fun), (rock fun)*/

            int length = 3;

            Console.WriteLine("Podaj k");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[k];

            Wypisz(arr, 0, 0, length);

            Console.ReadKey();
        }
    }
}
