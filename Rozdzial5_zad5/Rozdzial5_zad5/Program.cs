using System;

namespace Rozdzial5_zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 5. Write a program that asks for a digit (0-9), and depending on the input, 
             * shows the digit as a word (in English). Use a switch statement.
             */

            Console.WriteLine("Podaj liczbe z zakresu 0-9");
            int liczba = int.Parse(Console.ReadLine());

            switch(liczba)
            {
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                    break;
                case 3:
                    Console.WriteLine("trzy");
                    break;
                case 4:
                    Console.WriteLine("cztery");
                    break;
                case 5:
                    Console.WriteLine("piec");
                    break;
                case 6:
                    Console.WriteLine("szesc");
                    break;
                case 7:
                    Console.WriteLine("siedem");
                    break;
                case 8:
                    Console.WriteLine("osiem");
                    break;
                case 9:
                    Console.WriteLine("dziewiec");
                    break;
                case 0:
                    Console.WriteLine("zero");
                    break;
                default:
                    Console.WriteLine("Podano liczbe spoza zakresu");
                    break;

            }


            Console.ReadLine();
        }
    }
}
