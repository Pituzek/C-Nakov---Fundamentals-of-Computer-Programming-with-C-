using System;

namespace Rozdzial9_zad9
{
    class Program
    {
        static int ZnajdzNajwiekszaLiczbe(int[] tablica, int start, int end)
        {
            int maks = tablica[start];
            int maksSave = 0;
            int indeks = 0;
            int tmp = 0;

            for (int i = start; i < end; i++)
            {

                for (int j = i + 1; j < end; j++)
                {
                    if (tablica[j] > maks)
                    {
                        maks = tablica[j];
                        indeks = j;
                    }

                }

                tmp = tablica[i];
                tablica[i] = tablica[indeks];
                tablica[indeks] = tmp;
                if (maksSave < maks) maksSave = maks;
                maks = 0;

            }

            return maksSave;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("9. Write a method that finds the biggest element of an array. Use that method to implement sorting in descending order.");

            Console.WriteLine("\n Podaj wielkosc tablicy n");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            for( int i=0; i<n; i++)
            {
                Console.WriteLine("Element {0}: ", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Podaj indeks startowy");
            int startIndeks = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj indeks koncowy");
            int koncowyIndeks = int.Parse(Console.ReadLine());


            int maks = ZnajdzNajwiekszaLiczbe(tab, startIndeks, koncowyIndeks);


            Console.WriteLine("Maks liczba z tablicy to: {0}", maks);

            foreach( int liczba in tab)
            {
                Console.Write("{0}", liczba);
            }

            Console.ReadKey();
        }
    }
}
