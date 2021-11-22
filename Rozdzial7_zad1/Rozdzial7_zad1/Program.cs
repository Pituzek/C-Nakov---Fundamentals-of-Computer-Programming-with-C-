using System;

namespace Rozdzial7_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals to the index of the element multiplied by 5. Print the elements to the console.");

            Console.WriteLine("Podaj 20 liczb");

            int[] liczby = new int[20];

            for ( int i=0; i < liczby.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbe", i+1);
                liczby[i] = int.Parse(Console.ReadLine());
                liczby[i] *= 5;
            }

            foreach(int liczba in liczby)
            {
                Console.Write("{0}"+" ", liczba);
            }

            Console.ReadKey();

        }
    }
}
