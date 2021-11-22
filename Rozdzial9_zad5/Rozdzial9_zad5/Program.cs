using System;

namespace Rozdzial9_zad5
{
    class Program
    {

        static bool SprawdzElement( int pozycja, params int[] tablica)
        {
            bool info = false;
            int max = tablica.Length - 1;

            if (pozycja == 0)
            {
                if(tablica[pozycja] > tablica[pozycja + 1])
                {
                    info = true;
                }
                else
                {
                    info = false;
                }
            }
            else if (pozycja > 1 && pozycja < tablica.Length - 1)
            {
                if (tablica[pozycja] > tablica[pozycja + 1] && tablica[pozycja] > tablica[pozycja - 1])
                {
                    info = true;
                }
                else
                {
                    info = false;
                }
            }
            else if (pozycja == max)
            {
                if(tablica[pozycja] > tablica[pozycja - 1])
                {
                    info = true;
                }
                else
                {
                    info = false;
                }
            }

            return info;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("5. Write a method that checks whether an element, from a certain position in an array is greater than its two neighbors. Test whether the method works correctly.");

            Console.WriteLine("Podaj dlugosc tablicy");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Wpisz elementy do tablicy");
            int[] tab = new int[n];

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Element {0}:", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Wpisz pozycje elementu do sprawdzenia");
            int indeks = int.Parse(Console.ReadLine());

            bool wiekszy = false;

            wiekszy = SprawdzElement(indeks, tab);

            Console.WriteLine(wiekszy);

            Console.ReadKey();
        }
    }
}
