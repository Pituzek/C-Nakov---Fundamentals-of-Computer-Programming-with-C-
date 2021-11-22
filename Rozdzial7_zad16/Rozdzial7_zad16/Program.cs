using System;

namespace Rozdzial7_zad16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("16. Write a program, which uses a binary search in a sorted array of integer numbers to find a certain element.");

            Console.WriteLine("Podaj wielkosc tablicy n");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            for( int i=0; i<n; i++)
            {
                Console.Write("Element {0}: ", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Wpisz liczbe");
            int liczba = int.Parse(Console.ReadLine());

            int indeks = 0;

            int index = Array.BinarySearch(tab, liczba);

            for ( int i=0; i<tab.Length; i++ )
            {
                if (tab[i] == liczba) indeks = i;
            }

            Console.WriteLine("metoda for: {0}, metoda Binary search: {1} ", indeks, index);

            Console.ReadKey();
        }
    }
}
