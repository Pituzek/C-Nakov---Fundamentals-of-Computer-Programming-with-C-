using System;

namespace Rozdzial4_zad9
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *  9. Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
             */


            Console.WriteLine("Ile liczb n, chciałbyś zsumować?");
            int ile = int.Parse(Console.ReadLine());

            double ileTab = ile;

            double[] tab = new double[(int)ileTab];

            

            for (int i = 0; i < ile; i++)
            {
                Console.WriteLine("Podaj liczbe nr {0}", i);
                tab[i] = double.Parse(Console.ReadLine());
            }

            double suma = 0;

            foreach (double l in tab)
            {
                
                suma += l;
            }

            Console.WriteLine("Suma podanych liczb wynosi: {0}", suma);
            Console.ReadKey();
        }
    }
}
