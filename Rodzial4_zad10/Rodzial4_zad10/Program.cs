using System;

namespace Rodzial4_zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           10. Write a program that reads an integer number n from the console and prints all 
               numbers in the range[1…n], each on a separate line.
            */
            
            Console.WriteLine("Podaj liczbe całkowitą n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for (int i=1; i<=n; i++)
            {
                int l =+ i;
                Console.WriteLine(l);

            }

            Console.ReadKey();

        }
    }
}
