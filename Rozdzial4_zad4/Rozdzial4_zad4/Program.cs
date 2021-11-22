using System;

namespace Rozdzial4_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            4. Write a program that prints three numbers in three virtual columns on the console.
            Each column should have a width of 10 characters and the numbers should be left aligned. 
            The first number should be an integer in hexadecimal; the second should be fractional positive; 
            and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.

            */

            int a = 2021;
            double b = 10.435;
            double c = -2.434; 

            Console.WriteLine(" {0,-10:X2} \n {1,-10:F2} \n {2,-10:F2} \n", a,b,c);

            Console.ReadKey();
        }
    }
}
