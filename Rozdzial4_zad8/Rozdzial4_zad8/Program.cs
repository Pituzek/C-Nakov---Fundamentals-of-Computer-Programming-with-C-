using System;

namespace Rozdzial4_zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 8.Write a program that reads five numbers from the console and prints the greatest of them.
             */

            Console.WriteLine("Ile liczb chcesz wpisac do konsoli?");
            int ile = int.Parse(Console.ReadLine());

            najwieksza(ile);
        }

        static void najwieksza(double liczby)
        {

            double najw = 0;
            double[] tab = new double[(int)(liczby)];

            for (int i=0; i<liczby;i++)
            {
                Console.WriteLine("Podaj liczbe nr {0}",i);

                tab[i] = double.Parse(Console.ReadLine());

                najw = tab[i] > najw ? tab[i] : najw;

            }

            Console.WriteLine("Najwieksza liczba z podanych to: {0}", najw);
            Console.ReadKey();

        }
    }
}
