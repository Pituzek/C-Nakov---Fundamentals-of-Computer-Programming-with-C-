using System;
using System.Net;

namespace Rozdzial12_zad13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("13. Write a program to download a file from Internet by given URL,");

            WebClient wb = new WebClient();

            string link = @"https://introprogramming.info/wp-content/uploads/2013/07/Books/CSharpEn/Fundamentals-of-Computer-Programming-with-CSharp-Nakov-eBook-v2013.pdf";
            string file = @"C:\Users\piotr\Desktop\C";

            try
            {
                wb.DownloadFile(link, file);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The address or fileName parameter is null!");
            }
            catch (WebException)
            {
                Console.WriteLine("Error! Possible causes:\n1. The URI formed by combining BaseAddress and address is invalid.\n2. filename is null or Empty.\n3. The file does not exist.\n4. An error occurred while downloading data.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }

            Console.ReadKey();
        }
    }
}
