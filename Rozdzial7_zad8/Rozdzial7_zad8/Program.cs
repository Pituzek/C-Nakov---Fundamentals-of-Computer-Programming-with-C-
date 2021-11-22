using System;

namespace Rozdzial7_zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8. Sorting an array means to arrange its elements in an increasing (or decreasing) order. Write a program, which sorts an array using the algorithm selection sort.");

            Console.WriteLine("Podaj wielkosc tablicy n");
            int n = int.Parse(Console.ReadLine());
            
            int[] tab = new int[n];

            int temp, najmniejszy;

            for(int i=0;i<n;i++)
            {
                Console.Write("Element {0}: ", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n-1; i++)
            {

                najmniejszy = i;

                for(int j=i+1; j<n; j++)
                {
                    if(tab[j]<tab[najmniejszy])
                    {
                        najmniejszy = j;
                    }
                }

                if (najmniejszy != i)
                {
                    temp = tab[najmniejszy];
                    tab[najmniejszy] = tab[i];
                    tab[i] = temp;
                }
            }

            Console.WriteLine();
            Console.Write("Posortowana tablica: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(tab[i] + " ");
            }

                Console.ReadKey();
        }
    }
}
