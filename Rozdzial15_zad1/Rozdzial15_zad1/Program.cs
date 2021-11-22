using System;
using System.IO;
using System.Text.Encoding.CodePages;

namespace Rozdzial15_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Write a program that reads a text file and prints its odd lines on the console.");

            //System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);
            //StreamReader streamReader = new StreamReader("../../test.001.in.txt", encoding);

            //StreamWriter streamWriter = new StreamWriter("../../test.001.out.txt", false, encoding);

            /*
             * 
             * https://stackoverflow.com/questions/50858209/system-notsupportedexception-no-data-is-available-for-encoding-1252
             * https://www.nuget.org/packages/System.Text.Encoding.CodePages/
             * 
             * Add a reference to the System.Text.Encoding.CodePages.dll assembly to your project.
               Retrieve a CodePagesEncodingProvider object from the static Instance property.
               Pass the CodePagesEncodingProvider object to the Encoding.RegisterProvider method.
             * 
             */

            StreamReader streamReader = new StreamReader("../../test.001.in.txt");

            StreamWriter streamWriter = new StreamWriter("../../test.001.out.txt", false);

            using(streamReader)
            {
                using(streamWriter)
                {
                    int lineCounter = 0;
                    string oddLineContent = streamReader.ReadLine();

                    while(oddLineContent != null)
                    {
                        lineCounter++;

                        if (lineCounter % 2 == 1)
                        {
                            streamWriter.WriteLine(oddLineContent);
                            Console.WriteLine(oddLineContent);
                        }
                        oddLineContent = streamReader.ReadLine();
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
