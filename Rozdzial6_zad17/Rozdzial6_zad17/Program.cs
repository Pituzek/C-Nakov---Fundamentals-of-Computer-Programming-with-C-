using System;

namespace Rozdzial6_zad17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("17. Write a program that given two numbers finds their greatest common divisor(GCD) and their least common multiple(LCM).");

            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            int a1 = a;
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            int b1 = b;

            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }

            if (a == 0)
            {
                Console.WriteLine("GCD= {0}",b);
                Console.WriteLine("LCM= {0}", (a1 * b1) / b);
            }
            else
            {
                Console.WriteLine("GCD= {0}", a);
                Console.WriteLine("LCM= {0}", (a1 * b1) / a);
            }

            Console.ReadKey();
        }
    }
}
