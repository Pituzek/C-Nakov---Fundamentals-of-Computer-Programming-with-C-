using System;

namespace Rozdzial12_zad7
{

    class Program
    {
        public static double Pierwiastek(double liczba)
        {
            liczba = Math.Sqrt(liczba);
            return liczba;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("7. Write a program that takes a positive integer from the console and prints the square root of this integer. If the input is negative or invalid print \"Invalid Number\" in the console. In all cases print \"Good Bye\".");

            Console.Write("\nEnter number: ");
            string input = Console.ReadLine();
            int n = -1;
            bool invalidNumber = false;

             try
             {
                n = Convert.ToInt32(input);
             }
             catch (FormatException e)
             { 
                Console.WriteLine("Invalid number!");
                invalidNumber = true;
             }
             finally
             {
                if (n < 0)
                {
                    if (!invalidNumber) Console.WriteLine("Invalid number!");
                }
                else Console.WriteLine(Math.Sqrt(n));    
             }

            Console.WriteLine("Good Bye");

            Console.ReadKey();
        }
    }
}
