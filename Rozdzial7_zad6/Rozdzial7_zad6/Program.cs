using System;

namespace Rozdzial7_zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6. Write a program, which finds the maximal sequence of increasing elements in an array arr[n]. It is not necessary the elements to be consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.");

            Console.WriteLine("Podaj wielkosc tablicy n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadz n liczb do tablicy");

            int[] tab = new int[n];
            int[] wynik = new int[n];
            int counter = 0, tempIndex, tempCounter;

            for (int i=0; i<tab.Length;i++)
            {
                Console.Write("Wprowadz element {0}", i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tab.Length; i++)
            {
                int[] tempWynik = new int[n];
                tempIndex = tempCounter = 1;
                tempWynik[0] = tab[i];

                for (int j = i + 1; j < n; j++)
                {
                    if (tab[j] > tempWynik[tempIndex - 1])
                    {
                        tempWynik[tempIndex] = tab[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && tab[j] > tempWynik[tempIndex - 2] && tab[j] < tempWynik[tempIndex - 1]) tempWynik[tempIndex - 1] = tab[j];
                }

                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    wynik = tempWynik;
                }
            }


            for (int i = 0; i < counter; i++) Console.Write("{0},", wynik[i]);
            Console.ReadKey();
        }
    }
}
