using System;

namespace Rozdzial7_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. Write a program, which compares two arrays of type char lexicographically (character by character) and checks, which one is first in the lexicographical order.");

            bool arrayEqual = true;
            char[] arrA = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] arrB = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            if (arrA.Length > arrB.Length) Console.WriteLine("\nSecond array is lexicographicaly first.");
            else if (arrA.Length < arrB.Length) Console.WriteLine("\nFirst array is lexicographicaly first.");
            else
            {
                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] < arrB[i])
                    {
                        Console.WriteLine("\nFirst array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                    if (arrA[i] > arrB[i])
                    {
                        Console.WriteLine("\nSecond array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                }

                if (arrayEqual) Console.WriteLine("\nArrays are lexicographicaly equal.");

                Console.ReadKey();
            }
        }
    }
}
