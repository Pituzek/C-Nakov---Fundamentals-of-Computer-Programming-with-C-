using System;

namespace Rozdzial9_zad4
{



    class Program
    {
        static void SzukajLiczbe(int[] tablica, int x)
        {
            int licznik = 0;

            for( int i=0; i<tablica.Length; i++)
            {

                if (tablica[i] == x) licznik++;

            }

            Console.WriteLine("Liczba {0}, zostala znaleziona {1} razy", x, licznik);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("4. Write a method that finds how many times certain number can be found in a given array. Write a program to test that the method works correctly.");

            Console.WriteLine("Wpisz szukana liczbe");
            int liczba = int.Parse(Console.ReadLine());

            int[] tab = { 1, 2, 3, 1, 5, 5, 4, 6, 7, 7, 1, 3, 8, 9 };

            SzukajLiczbe(tab, liczba);

            Console.ReadKey();
        }
    }
}
