using System;
using System.Text.RegularExpressions;

namespace Rozdzial13_zad16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("16. Write a program that replaces all hyperlinks in a HTML document consisting of <a href=\"…\">…</a> and hyperlinks in \forum\" style, which look like [URL=…]…[/URL].");

            string sample = "<p>Please visit <a href=\"http://softuni.org\">our site</a> to choose a training course. Also visit <a href= \"http://forum.softuni.org\">our forum</a> to discuss the courses.</p>";

            //Regex r = new Regex(@"<a.*?href=(""|')(?<href>.*?)(""|').*?>(?<value>.*?)</a>");
            /*
            Match m = r.Match(sample);
            if (m.Success)
                Console.WriteLine(m.Result("\n \"${href}\" \n \"${value}\""));
            */
            string change = Regex.Replace(sample, "<a href=", "[URL=");
            change = Regex.Replace(change, "</a>", "[/URL]");
            change = Regex.Replace(change, "[^p]>", "]");

            String pattern2 = "['\"]";
            change = Regex.Replace(change, pattern2, "");

            Console.WriteLine(change);

            Console.ReadKey();
        }
    }
}
