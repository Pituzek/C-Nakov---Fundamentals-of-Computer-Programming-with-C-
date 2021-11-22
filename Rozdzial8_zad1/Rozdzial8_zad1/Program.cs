using System;

namespace Rozdzial8_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.");

            int[] tab = { 151, 35, 43, 251, 1023, 1024 };

            string[] wyniki = new string[6];

            int indeks = 0;

            foreach(int liczba in tab)
            {

               wyniki[indeks] = Convert.ToString(liczba, 2);
               indeks++;

            }

            foreach(string i in wyniki)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }
    }
}
