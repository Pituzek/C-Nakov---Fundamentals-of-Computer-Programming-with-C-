using System;

namespace Rozdzial7_zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5. Write a program, which finds the maximal sequence of consecutively placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.");

            Console.WriteLine("Podaj wielkosc tablicy");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];
        
            for(int i=0;i<tab.Length;i++)
            {
                Console.WriteLine("Podaj element {0}:",i);
                tab[i] = int.Parse(Console.ReadLine());
            }

            int sekw = 1, sekwZap = 1, start=0, ostatniElem=0;

            for(int i=0;i<tab.Length-1;i++)
            {
                if (tab[i] + 1 == tab[i + 1])
                {

                    sekw++;

                    if (sekw > sekwZap)
                    {
                        sekwZap = sekw;
                        ostatniElem = i + 1;
                        start = ostatniElem - sekwZap + 1;
                    }
                }
                else
                {
                    sekw = 1;
                }

            }


            for (int i = start; i < sekwZap+start; i++) Console.Write("{0} ", tab[i]);
            Console.ReadKey();
        }
    }
}
