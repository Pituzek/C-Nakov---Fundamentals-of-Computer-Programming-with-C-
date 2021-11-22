using System;

namespace Rozdzial9_zad2
{
    class Program
    {
        static int a; // zmienna globalna
        static void GetMax(int x, int y)
        {
            
            if (x > y) a = x;
            else a = y;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("2. Create a method GetMax() with two integer (int) parameters, that returns maximal of the two numbers. Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax() method you just created. Write a test program that validates that the methods works correctly.");

            Console.WriteLine("Podaj liczbe a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c");
            int c = int.Parse(Console.ReadLine());


            GetMax(a, b);
            GetMax(a, c);

            Console.WriteLine("Najwieksza liczba to: {0}", a);

            Console.ReadKey();
        }
    }
}
