using System;

namespace Rozdzial7_zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program, which finds the most frequently occurring element in an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times).");

            Console.WriteLine("Podaj wielkosc tablicy n");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            for(int i=0; i<n; i++)
            {
                Console.Write("Element {0}: ", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            int wartDoPorow, liczba=0, liczbaZap=0, licznik=0, licznikZap=0;

            for (int i=0; i<n-1; i++)
            {
                wartDoPorow = tab[i];
                
                licznik = 0;

                for(int j=0; j<n; j++)
                {
                    if (wartDoPorow == tab[j]) 
                    {
                        licznik++;
                        liczba = wartDoPorow;
                    }
                }

                if (licznik > licznikZap)
                {
                    licznikZap = licznik;
                    liczbaZap = liczba;
                }

            }

            Console.WriteLine("Liczba wystapien {0} dla liczby {1}", licznikZap,liczbaZap);

            Console.ReadKey();
        }
    }
}
