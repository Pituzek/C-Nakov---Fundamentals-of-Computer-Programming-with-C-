using System;

namespace Rozdzial7_zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7. Write a program, which reads from the console two integer numbers N and K (K<N) and array of N integers. Find those K consecutive elements in the array, which have maximal sum.");

            Console.WriteLine("Podaj N");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj K - K<N");
            int k = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write(" Element {0}: ", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(tab, (a, b) => b.CompareTo(a));
            
            // posortowana tablica, zaczynajac od najwiekszej wartosci
            foreach(int liczby in tab)
            {
                Console.Write(liczby + " ");
            }

            int sum = 0;

            for (int i = 0; i < k; i++) sum += tab[i];

            Console.WriteLine("\nBiggest sum is {0}", sum);

            Console.ReadKey();
        }
    }
}
