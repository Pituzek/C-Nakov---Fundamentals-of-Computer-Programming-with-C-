using System;

namespace Rozdzial5_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Write an if-statement that takes two integer variables and exchanges 
             * their values if the first one is greater than the second one. 
             */


            Console.WriteLine("Podaj liczbe a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe b");
            double b = double.Parse(Console.ReadLine());

            double tmp;

            if (a>b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }

            Console.WriteLine("a:{0} b:{1}", a, b);


            Console.ReadKey();


           
        }
    }
}
