using System;
using System.Globalization;

namespace Rozdzial13_zad17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("17. Write a program that reads two dates entered in the format \"day.month.year\" and calculates the number of days between them.");

            string pattern = "dd/M/yyyy";

            Console.WriteLine("Podaj pierwsza date (day.month.year)");
            var data1 = DateTime.ParseExact(Console.ReadLine(), pattern, null);

            Console.WriteLine("Podaj druga date (day.month.year)");
            var data2 = DateTime.ParseExact(Console.ReadLine(), pattern, null);
                  
            TimeSpan ts = data2 - data1;
            double totalDays = ts.TotalDays;

            Console.WriteLine("\nRóżnica dni wynosi: {0}", totalDays);

            Console.ReadKey();
        }
    }
}
