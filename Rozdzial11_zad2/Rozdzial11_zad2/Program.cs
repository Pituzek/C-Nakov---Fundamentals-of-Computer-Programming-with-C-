using System;

namespace Rozdzial11_zad2
{
    class Program
    {
        private static Random rnd = new Random();
        static void PrintRandom(int[] tablica)
        {

            foreach(int liczba in tablica)
            {
                Console.Write("{0} ,",liczba);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("2. Write a program, which generates and prints on the console 10 random numbers in the range [100, 200].");

            int[] tab = new int[10];

            for(int i=0; i<10; i++)
            {
                tab[i] = rnd.Next(100, 201);
            }

            PrintRandom(tab);

            Console.ReadKey();
        }
    }
}
