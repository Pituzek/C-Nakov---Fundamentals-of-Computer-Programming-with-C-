using System;
using System.IO;
using System.Text;

namespace Rozdzial12_zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10. Write a method that takes as a parameter the name of a binary file, reads the content of the file and returns it as an array of bytes. Write a method that writes the file content to another file. Compare both files.");

            var fileName = @"C:\Users\piotr\Desktop\test.txt";
            var fileNameCopy = @"C:\Users\piotr\Desktop\testCopy.txt";

            //using (MemoryStream ms = new MemoryStream()) ;
            using FileStream fs = File.OpenRead(fileName);
            
            //byte[] buf = new byte[1024];
           
            
            byte[] buff = File.ReadAllBytes(fileName);
            File.WriteAllBytes(fileNameCopy, buff);


            /*
            int c;

            using (MemoryStream ms = new MemoryStream())
            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                // byte[] bytes = new byte[file.Length];
                //file.Read(bytes, 0, (int)file.Length);
                //ms.Write(bytes, 0, (int)file.Length);
                while ((c = file.Read(buf, 0, buf.Length)) > 0)
                {
                    // Console.WriteLine(Encoding.UTF8.GetString(buf, 0, c));
                    file.Read(buf, 0, buf.Length);
                    ms.Write(buf, 0, buf.Length);

                }
            }


            /Read file to byte array

FileStream stream = File.OpenRead(@"c:\path\to\your\file\here.txt");
byte[] fileBytes= new byte[stream.Length];

stream.Read(fileBytes, 0, fileBytes.Length);
stream.Close();
//Begins the process of writing the byte array back to a file

using (Stream file = File.OpenWrite(@"c:\path\to\your\file\here.txt"))
{
   file.Write(fileBytes, 0, fileBytes.Length);
}
            */

            Console.ReadKey();
        }
    }
}
