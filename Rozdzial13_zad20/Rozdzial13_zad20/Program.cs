using System;
using System.Text.RegularExpressions;

namespace Rozdzial13_zad20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20. Write a program that extracts from a text all dates written in format DD.MM.YYYY and prints them on the console in the standard format for Canada. Sample text:");

            string sampleText = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

            Regex r = new Regex(@"(?<day>\d{1,2})\.(?<month>\d{1,2})\.(?<year>\d{4})");

            MatchCollection dateMatch = r.Matches(sampleText);

            foreach( Match m in dateMatch)
            {
                Console.WriteLine(m.Result("\n ${day}.${month}.${year}"));
            }

            Console.ReadKey();
        }
    }
}
