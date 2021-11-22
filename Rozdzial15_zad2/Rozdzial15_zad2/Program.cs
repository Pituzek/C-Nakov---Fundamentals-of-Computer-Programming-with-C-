using System;
using System.IO;
using System.Text;

namespace Rozdzial15_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. Write a program that joins two text files and records the results in a third file.");

            StreamReader firstFileReader = new StreamReader("../../file1.txt");

            StreamReader secondFileReader = new StreamReader("../../file2.txt");

            StringBuilder firstText = new StringBuilder();

            using(firstFileReader)
            {
                firstText.Append(firstFileReader.ReadToEnd());
                Console.WriteLine(firstText);
            }

            StringBuilder secondText = new StringBuilder();

            using(secondFileReader)
            {
                secondText.Append(secondFileReader.ReadToEnd());
                Console.WriteLine(secondText);
            }

            StreamWriter thirdFileWrite = new StreamWriter("../../file3.txt");

            using(thirdFileWrite)
            {
                thirdFileWrite.WriteLine(firstText);
                thirdFileWrite.WriteLine(secondText);
            }

            Console.ReadKey();
        }
    }
}
