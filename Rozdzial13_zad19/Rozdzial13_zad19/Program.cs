using System;
using System.Text.RegularExpressions;

namespace Rozdzial13_zad19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("19. Write a program that extracts all e-mail addresses from a text. These are all substrings that are limited on both sides by text end or separator between words and match the shape <sender>@<host>…<domain>. Sample text:");

            string sampleText = @"Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";

            Regex r = new Regex(@"(?<sender>\w+\.\w+|\w+)@(?<host>\w+)\.(?<domain>\w+\.\w{2,}|\w{2,})");

            //Match m = r.Match(sampleText);
            //if (m.Success)
            //    Console.WriteLine(m.Result("\n \"${sender}\" \n \"${host}\" \"${domain}\""));

            MatchCollection emailMatches = r.Matches(sampleText);

            foreach ( Match mm in emailMatches)
            {
                Console.WriteLine(mm.Result("\n ${sender}@${host}.${domain}"));
            }


            Console.ReadKey();
        }
    }
}
