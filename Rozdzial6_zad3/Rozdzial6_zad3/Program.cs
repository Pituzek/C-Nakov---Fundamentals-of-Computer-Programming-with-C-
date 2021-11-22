using System;

namespace Rozdzial6_zad3
{
    class Program
    {
        /*
         * 3. Write a program that reads from the console a series of integers and prints
         * the smallest and largest of them.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zakres liczb N");
            int zakres = int.Parse(Console.ReadLine());

            int min = 0;
            int max = 0;

            for (int i=0;i<zakres;i++)
            {
                Console.WriteLine("Podaj liczbe");
                int liczba = int.Parse(Console.ReadLine());

                if (i == 0) min = max = liczba;

                if (min > liczba) min = liczba;
                if (max < liczba) max = liczba;


            }
            Console.WriteLine("Max {0} ; Min {1}", max, min);
            Console.ReadKey();
        }
    }
}
