using System;

namespace Rozdzial7_zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console. WriteLine("11. Write a program to find a sequence of neighbor numbers in an array, which has a sum of certain number S.Example: { 4, 3, 1, 4, 2, 5, 8},S = 11  { 4, 2, 5}.");

            Console.WriteLine("Podaj sume S");
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wielkosc tablicy n");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            for(int i=0; i<n; i++)
            {
                Console.Write("Element {0}: ", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            int poczatek = 0, koniec = 0, suma=0;
            bool znaleziono = false;

            for(int i=0; i<n-1; i++)
            {
                suma = tab[i]; //indeks startu liczenia

                for(int j=i+1; i<n; j++)
                {
                    suma += tab[j];

                    if (suma == s)
                    {
                        poczatek = i;
                        koniec = j;
                        znaleziono = true;
                        break;
                    }

                    if (suma > s) break;
                }

                if (znaleziono) break;

            }

            Console.WriteLine("");

            if (znaleziono)
            {
                for (int i = poczatek; i <= koniec; i++)
                {
                    Console.Write("{0}, ", tab[i]);
                }
            }
            else
            {
                Console.WriteLine("Nie znaleziono rozwiazania");
            }

            Console.ReadKey();
        }
    }
}
