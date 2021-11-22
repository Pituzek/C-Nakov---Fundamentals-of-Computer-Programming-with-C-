using System;

namespace Rozdzial9_zad6
{
    class Program
    {

        static int number = int.MinValue;
        static int indeks = 0;
        static void ZnajdzElement(int[] tablica)
        {
            for (int i=1; i<tablica.Length - 1; i++)
            {
                if(tablica[i] > tablica[i-1] && tablica[i] > tablica[i+1])
                {
                    number = tablica[i];
                    indeks = i;
                    break;
                }

            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("6. Write a method that returns the position of the first occurrence of an element from an array, such that it is greater than its two neighbors simultaneously. Otherwise the result must be -1.");

            Console.WriteLine("Wpisz wielkosc tablicy n");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Element {0}: ", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            ZnajdzElement(tab);

            if (number == int.MinValue) Console.WriteLine("-1");
            else Console.WriteLine("{0} jest wiekszy niz sasiednie cyfry. Znajduje sie na pozycji {1}", number, indeks);


            Console.ReadKey();
        }
    }
}
