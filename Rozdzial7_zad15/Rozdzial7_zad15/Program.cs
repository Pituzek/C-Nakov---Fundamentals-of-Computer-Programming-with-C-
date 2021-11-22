using System;

namespace Rozdzial7_zad15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("15. Write a program, which creates an array containing all Latin letters. The user inputs a word from the console and as result the program prints to the console the indices of the letters from the word.");
            char[] alfabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Wpisz slowo");
            char[] slowo = (Console.ReadLine().ToCharArray());

            for( int i = 0; i < slowo.Length; i++)
            {
                for( int j=0; j<alfabet.Length; j++)
                {
                    if ( slowo[i] == alfabet[j]) Console.Write("{0}, ", j);
                }

            }

            Console.ReadKey();
        }
    }
}
