using System;

namespace Rozdzial5_zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 10. Write a program that applies bonus points to given scores in the range [1…9] 
             * by the following rules:
                - If the score is between 1 and 3, the program multiplies it by 10.
                - If the score is between 4 and 6, the program multiplies it by 100.
                - If the score is between 7 and 9, the program multiplies it by 1000.
                - If the score is 0 or more than 9, the program prints an error message.
             */

            Console.WriteLine("Podaj wynik pomiedzy 1 a 9");
            double wynik = double.Parse(Console.ReadLine());

            switch(wynik)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Wynik: {0}", wynik * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Wynik: {0}", wynik * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Wynik: {0}", wynik * 1000);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            // lub z pomoca if else:

            /*
             * 
             * 
             * 
            byte points;
            Console.Write("Enter points between 1 and 9: ");
            points = Convert.ToByte(Console.ReadLine());
            if (points >= 1 && points <= 3)
                Console.WriteLine("Points multiplied by 10: {0}", points * 10);
            else if (points >= 4 && points <= 6)
                Console.WriteLine("Points multiplied by 100: {0}", points * 100);
            else if (points >= 7 && points <= 9)
                Console.WriteLine("Points multiplied by 1000: {0}", points * 1000);
            else
                Console.WriteLine("Wrong Input!");
            Console.ReadLine();
             * 
             * 
             */

            Console.ReadLine();
        }
    }
}
