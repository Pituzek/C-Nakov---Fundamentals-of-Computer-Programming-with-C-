using System;

namespace Rozdzial5_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4. Sort 3 real numbers in descending order. Use nested if statements.
             */
            //https://github.com/ivanpop/CS-for-Dummies/blob/master/Chapter%205%20Solution%204/Program.cs

            Console.WriteLine("Podaj liczbe a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe c");
            int c = int.Parse(Console.ReadLine());


            if (a < b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;

                    if (b > c) // DLA 4 5 6 NIE DZIALA USPRAWNIC
                    {
                        a = a + b;
                        b = a - b;
                        a = a - b;
                    }
                }
                else if (a >= c)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            else if (a == b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
            }
            else
            {
                if (b < c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;
                }
                if (a < b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
            Console.ReadLine();


        }
    }
}
