using System;

namespace Rozdzial7_zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9. Write a program, which finds a subsequence of numbers with maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11");

            int suma = 0, tempSuma;

            Console.WriteLine("Podaj wielkosc tablicy N");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            for(int i=0; i<n; i++)
            {
                Console.Write("Element {0}: ", i);
                tab[i] = int.Parse(Console.ReadLine());

            }

            for(int i=0; i < n - 1; i++)
            {
                tempSuma = tab[i];

                for(int j=i+1; j<n; j++)
                {
                    tempSuma += tab[j];
                    if (tempSuma > suma) suma = tempSuma ;
                }

            }

            Console.WriteLine("Wynik= {0}", suma);

            Console.ReadKey();
        }
    }
}
