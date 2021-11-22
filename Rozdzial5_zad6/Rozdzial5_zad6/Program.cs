using System;


namespace Rozdzial5_zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 6. Write a program that gets the coefficients a, b and c of a quadratic equation:
             * ax2 + bx + c, calculates and prints its real roots (if they exist). 
             * Quadratic equations may have 0, 1 or 2 real roots.
             */

            Console.WriteLine("Podaj a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b,2) - (4 * a * c);

            double x1 = 0, x2 = 0;

            if (delta > 0)
            {
                x1 = ((b * -1) - Math.Sqrt(delta)) / (2 * a);
                x2 = ((b * -1) + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else if (delta == 0)
            {
                x1 = (b * -1) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
            }
            else
            {
                Console.WriteLine("Delta = {0}, brak rozwiazan", delta);
            }

            Console.ReadLine();
        }
    }
}
