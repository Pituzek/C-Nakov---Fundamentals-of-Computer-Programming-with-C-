using System;

namespace Rozdzial5_zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 11. * Write a program that converts a number in the range [0…999] to words,
             * corresponding to the English pronunciation. Examples:
                - 0 --> "Zero"
                - 12 --> "Twelve"
                - 98 --> "Ninety eight"
                - 273 --> "Two hundred seventy three"
                - 400 --> "Four hundred"
                - 501 --> "Five hundred and one"
                - 711 --> "Seven hundred and eleven"
             * 
             */

            Console.Write("Enter a number between 0 and 999: ");
            short number = Convert.ToInt16(Console.ReadLine());
            
            byte hundreds = (byte)((number / 100) | 0);
            byte tensAndOnes;

            Console.WriteLine(" {0}", hundreds);

            Console.ReadLine();
        }
    }
}
