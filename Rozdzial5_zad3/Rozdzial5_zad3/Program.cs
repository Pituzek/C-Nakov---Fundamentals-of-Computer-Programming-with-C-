using System;

namespace Rozdzial5_zad3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*3. Write a program that finds the biggest of three integers, 
             * using nested if statements. */

            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            if(a>b)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} is biggest", a);
                }
                else
                {
                    Console.WriteLine("{0} is biggest", c);
                }
            }
            else
            {
                if (b>c)
                {
                    Console.WriteLine("{0} is biggest", b);
                }
                else
                {
                    Console.WriteLine("{0} is biggest", c);
                }
            }

            Console.ReadKey();
        }
    }
}
