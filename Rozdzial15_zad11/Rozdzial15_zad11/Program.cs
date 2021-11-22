using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace Rozdzial15_zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("11. Write a program that deletes all words that begin with the word \"test\". The words will contain only the following chars: 0…9, a…z, A…Z.");

            StreamReader streamReader = new StreamReader("../../file1.in.txt");

            string file = streamReader.ReadToEnd();
            streamReader.Close();

            file = Regex.Replace(file, @"\btest\w+", "");
            file = Regex.Replace(file, @"\btest\b", "");

            StreamWriter streamWriter = new StreamWriter("../../file1.out.txt", false);
            streamWriter.Write(file);
            streamWriter.Close();

            Console.ReadKey();
        }
    }
}
