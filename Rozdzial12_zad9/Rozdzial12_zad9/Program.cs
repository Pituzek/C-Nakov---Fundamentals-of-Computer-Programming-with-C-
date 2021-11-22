using System;
using System.IO;

namespace Rozdzial12_zad9
{
    class Program
    {
        public static void ReadFile(string theSamefileName)
        {
            StreamReader reader = new StreamReader(theSamefileName);
            int lineNumber = 0;
            // Read first line from the text file
            string line = reader.ReadLine();
            // Read the other lines from the text file
            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
            }
            // Close the resource after you've finished using it
            reader.Close();
        }
            static void Main(string[] args)
        {
            Console.WriteLine("9. Write a method that takes as a parameter the name of a text file, reads the file and returns its content as string. What should the method do if and exception is thrown?");
            
            //string fileName = "C:\\Users\\piotr\\Desktop\\test.txt";
            string theSamefileName = @"C:\Users\piotr\Desktop\test.txt";

            try
            {
                ReadFile(theSamefileName);
            }
            catch(FileNotFoundException fefe)
            {
                Console.WriteLine("Plik {0}, nie został znaleziony", theSamefileName);
            }

            Console.ReadKey();
        }
    }
}
