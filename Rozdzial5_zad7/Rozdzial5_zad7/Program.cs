using System;

namespace Rozdzial5_zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 7. Write a program that finds the greatest of given 5 numbers.
             */

            Console.WriteLine("Podaj 5 liczb, a program znajdzie najwieksza z nich");

            Console.WriteLine("Podaj a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj d");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj e");
            double e = double.Parse(Console.ReadLine());

            if (a<b)
            {
                a = b;
            }
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;

            Console.WriteLine("Najwieksza liczba wynosi: {0}", a);
            

            Console.ReadLine();
        }
    }
}
