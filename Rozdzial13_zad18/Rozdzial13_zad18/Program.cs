using System;
using System.Globalization;

namespace Rozdzial13_zad18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("18. Write a program that reads the date and time entered in the format \"day.month.year hour: minutes:seconds\" and prints the date and time after 6 hours and 30 minutes in the same format.");

            string format = "dd/M/yyyy HH:mm:ss";

            Console.WriteLine("\nPodaj date i godzine w formacie: day.month.year hour:minutes:seconds");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), format, null);

            TimeSpan ts = new TimeSpan(6,30,0);
            DateTime dataCombined = data.Add(ts);
            Console.WriteLine("\n{0}",dataCombined);

            Console.ReadKey();
        }
    }
}
