using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Rozdzial15_zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9. Write a program that deletes all the odd lines of a text file.");

            StreamReader sr = new StreamReader("../../file1.in.txt");

            StringBuilder sb = new StringBuilder();

            using(sr)
            {
                int lineCount = 0;

                string oddLineContent = sr.ReadLine();

                while (oddLineContent != null)
                {
                    lineCount++;

                    if( lineCount %2 == 0)
                    {
                        sb.Append(oddLineContent);
                        if (!sr.EndOfStream)
                        {
                            sb.Append(Environment.NewLine);
                        }
                    }

                    oddLineContent = sr.ReadLine();
                }
            }

            StreamWriter sw = new StreamWriter("../../file1.out.txt");

            using(sw)
            {
                sw.Write(sb.ToString());
            }



            Console.ReadKey();
        }
    }
}
