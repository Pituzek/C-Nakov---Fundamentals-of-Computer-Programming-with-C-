using System;

namespace Rozdzial7_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.");

            Console.WriteLine("Podaj wielkosc tablicy");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            for(int i=0; i<tab.Length;i++)
            {
                Console.Write("Wpisz element nr {0}:", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            int count = 1, tempCount = 1, number = 0;

            for (int i = 0; i < tab.Length - 1; i++)
            {
                if (tab[i] == tab[i + 1]) tempCount++;
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                    number = tab[i];
                }

            }

            for (int i = 0; i < count; i++) Console.Write("{0}, ", number);

            Console.ReadKey();
        }
    }
}
