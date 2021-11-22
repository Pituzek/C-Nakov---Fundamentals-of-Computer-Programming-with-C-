using System;

namespace Rozdzial12_zad8
{
    class Program
    {
        public static void Zakres(int x, int y)
        {
            int number;
            Console.WriteLine("\nPodaj liczbe z zakresu start-end");
            number = int.Parse(Console.ReadLine());

            if (number <= x || number <= y)
            {
                for (int i = number; i <= number + 10; i++)
                {
                    Console.Write("\n{0} ,", i);
                }
            }
            else
            {
                Console.WriteLine("\nPodano liczbe spoza zakresu");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("8. Write a method ReadNumber(int start, int end) that reads an integer from the console in the range [start…end]. In case the input integer is not valid or it is not in the required range throw appropriate exception. Using this method, write a program that takes 10 integers a1, a2, …, a10 such that 1 < a1 < … < a10 < 100.");

            Console.WriteLine("Podaj zakres od - do (1 < a < 100)");
            Console.WriteLine("Start:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("End:");
            int end = int.Parse(Console.ReadLine());

            if (end < start + 9)
                Console.WriteLine("\nPodano zly zakres");
            else
                Zakres(start, end);

            Console.ReadKey();
        }
    }
}
