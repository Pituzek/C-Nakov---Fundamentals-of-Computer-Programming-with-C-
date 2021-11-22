using System;

namespace Rozdzial9_zad3
{
    class Program
    {

        static void NazwaReszty(int x)
        {
            switch (x)
            {
                case 0: 
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("Jeden");
                    break;
                case 2:
                    Console.WriteLine("Dwa");
                    break;
                case 3:
                    Console.WriteLine("Trzy");
                    break;
                case 4:
                    Console.WriteLine("Cztery");
                    break;
                case 5:
                    Console.WriteLine("Piec");
                    break;
                case 6:
                    Console.WriteLine("Szesc");
                    break;
                case 7:
                    Console.WriteLine("Siedem");
                    break;
                case 8:
                    Console.WriteLine("Osiem");
                    break;
                case 9:
                    Console.WriteLine("Dziewiec");
                    break;
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("3. Write a method that returns the English name of the last digit of a given number. Example: for 512 prints \"two\"; for 1024  \"four\".");

            Console.WriteLine("\nWpisz numer");
            int liczba = int.Parse(Console.ReadLine());
            int reszta = (liczba % 10);

            Console.WriteLine("");
            NazwaReszty(reszta);

            Console.ReadKey();
        }
    }
}
