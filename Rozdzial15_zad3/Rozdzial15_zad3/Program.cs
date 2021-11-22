using System;
using System.IO;
using System.Text;

namespace Rozdzial15_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. Write a program that reads the contents of a text file and inserts the line numbers at the beginning of each line," +
                " then rewrites the file contents.");

            string inputFile = string.Empty;

            string inputFilePath = "../../test1.in.txt";
            string outputFilePath = "../../test1.out.txt";

            inputFile = FileToString(inputFilePath);

            StreamWriter sw = new StreamWriter(outputFilePath, false);

            sw.WriteLine(inputFile);
            sw.Close();

            Console.ReadKey();
        }

        public static string FileToString(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();

            using( StreamReader streamReader = new StreamReader(inputFilePath) )
            {
                string line;
                int counter = 1;

                while ( (line = streamReader.ReadLine()) != null)
                {
                    sb.Append(counter);
                    sb.Append(". ");
                    sb.Append(line);
                    if (!streamReader.EndOfStream)
                    {
                        sb.Append(Environment.NewLine);
                    }
                    counter++;
                }
            }

            return sb.ToString();
        }

    }
}
