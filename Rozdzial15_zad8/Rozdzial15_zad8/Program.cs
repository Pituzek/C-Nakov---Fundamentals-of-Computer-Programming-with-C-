using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Rozdzial15_zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7. Write a program that replaces every occurrence of the substring \"start\" with \"finish\" in a text file." +
                "Can you rewrite the program to replace whole words only ? Does the program work for large files (e.g. 800 MB)?");

            string filePath = "../../File1.in.txt";
            string fileContent;

            fileContent = FileToString(filePath);
            fileContent = Regex.Replace(fileContent, @"(\s|^)start(\s)", "$1finish$2");
            fileContent = Regex.Replace(fileContent, @"\bstart\b", "finish");

            StreamWriter sw = new StreamWriter("../../File1.out.txt", false);

            sw.Write(fileContent);
            sw.Close();

            Console.ReadKey();
        }

        public static string FileToString(string filePath)
        {
            StringBuilder sb = new StringBuilder();

            StreamReader sr = new StreamReader(filePath);

            using (sr)
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    sb.Append(line);

                    if (!sr.EndOfStream)
                    {
                        sb.Append(Environment.NewLine);
                    }

                    line = sr.ReadLine();
                }
            }

            return sb.ToString();
        }
    }

}
