using System;

namespace Rozdzial13_zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6. A text is given. Write a program that modifies the casing of letters to uppercase at all places in the text surrounded by <upcase> and </upcase> tags. Tags cannot be nested.");

            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string start = "<upcase>";
            string end = "</upcase>";

            int indexStart = text.IndexOf(start);
            int indexEnd = text.IndexOf(end);
            int boldStart;
            int boldEnd;

            while( indexStart != -1 && indexEnd != -1)
            {
                boldStart = indexStart + start.Length - 1;
                boldEnd = indexEnd;

                string toReplace = text.Substring(boldStart, boldEnd - boldStart);
                text = text.Replace(toReplace, toReplace.ToUpper());

                indexStart = text.IndexOf(start, indexEnd);
                indexEnd = text.IndexOf(end, indexEnd +1);
            }

            text = text.Replace("<upcase>", "").Replace("</upcase>", "");

            //Console.WriteLine("Start: {0}; End: {1}", indexStart, indexEnd);
            Console.WriteLine("\n{0}", text);


            Console.ReadKey();
        }
    }
}
