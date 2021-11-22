using System;

namespace Rozdzial5_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 2. Write a program that shows the sign (+ or -) of the product of three real numbers,
             * without calculating it. Use a sequence of if operators.
             * 
             */

            int negativeNumbersCount = 0;

            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());

            if (a < 0)
            {
                negativeNumbersCount += 1;
            }

            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());

            if (b < 0)
            {
                negativeNumbersCount += 1;
            }

            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            if (c < 0)
            {
                negativeNumbersCount += 1;
            }


            if (a == 0 || b==0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (negativeNumbersCount % 2 == 0)
                {
                    Console.WriteLine("+");
                }
                else if (negativeNumbersCount % 2 != 0)
                {
                    Console.WriteLine("-");
                }

            }
            Console.ReadKey();
        }
    }
}
