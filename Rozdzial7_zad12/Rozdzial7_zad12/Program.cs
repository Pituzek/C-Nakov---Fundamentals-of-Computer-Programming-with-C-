using System;

namespace Rozdzial7_zad12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12. Write a program, which creates square matrices like those in the figures below and prints them formatted to the console. The size of the matrices will be read from the console. See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion");

            int x = 4, y = 4, a=0;
            
            for(int i=1; i<=y; i++)
            {
                Console.Write(i + " ");
                a += i;

                for(int j=1; j<x; j++)
                {
                    a += y;
                    Console.Write(a + " ");
                }

                a = 0;
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
