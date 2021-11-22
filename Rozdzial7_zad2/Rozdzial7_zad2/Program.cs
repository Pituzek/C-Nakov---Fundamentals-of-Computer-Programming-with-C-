using System;

namespace Rozdzial7_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).");

            Console.WriteLine("\nPodaj wielkosc pierwszej tablicy");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPodaj wielkosc drugiej tablicy");
            int m = int.Parse(Console.ReadLine());

            int[] tablica1 = new int[n];
            int[] tablica2 = new int[m];

            bool rowna = true;

            if (tablica1.Length != tablica2.Length) rowna = false;

            if (rowna)
            {
                Console.WriteLine("\nWpisz wartosci pierwszej tablicy");

                for( int i = 0; i < tablica1.Length; i++)
                {
                    tablica1[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nWpisz wartosci drugiej tablicy");

                for (int i = 0; i < tablica2.Length; i++)
                {
                    tablica2[i] = int.Parse(Console.ReadLine());
                }

                for(int i=0;i<tablica1.Length;i++)
                {
                    if (tablica1[i] != tablica2[i]) rowna = false;
                }

            }

            Console.WriteLine("\nTablice sa rowne? {0}", rowna);

            Console.ReadKey();
        }
    }
}
