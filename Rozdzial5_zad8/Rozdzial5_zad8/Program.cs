using System;

namespace Rozdzial5_zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 8. Write a program that, depending on the user’s choice, 
             * inputs int, double or string variable. 
             * If the variable is int or double, the program increases it by 1. 
             * If the variable is a string, the program appends "*" at the end. 
             * Print the result at the console. Use switch statement.
             */

            

            Console.WriteLine("Wybierz jakiego typu zmienna chcesz wprowadzic:");
            Console.WriteLine("1 - int");
            Console.WriteLine("2 - double");
            Console.WriteLine("3 - string");

            int wybor = int.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Wprowadz wartosc typu int");
                    int a = int.Parse(Console.ReadLine());
                    a += 1;
                    Console.WriteLine("Liczba a zwiekszona o 1 wynosi: {0}", a);
                    break;
                case 2:
                    Console.WriteLine("Wprowadz wartosc typu double");
                    double b = double.Parse(Console.ReadLine());
                    b += 1;
                    Console.WriteLine("Liczba b zwiekszona o 1 wynosi: {0}", b);
                    break;
                case 3:
                    Console.WriteLine("Wprowadz tekst");
                    string c = Console.ReadLine();
                   // c = c + "*";
                    Console.WriteLine(c + "*");
                    break;
                default:
                    Console.WriteLine("Wpisano liczbe spoza zakresu.");
                    break;
            }





            Console.ReadLine();
        }
    }
}
