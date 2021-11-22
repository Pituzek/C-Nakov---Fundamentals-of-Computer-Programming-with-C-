using System;

namespace Rozdzial8_zad3
{
    class Program
    {
        static void konwersja(string value)
        {
            Console.WriteLine("Konwersja {0} z hexadecimal na decimal: {1}", value, Convert.ToInt32(value, 16));
            Console.WriteLine("Konwersja {0} z hexadecimal na binary: {1}",value, Convert.ToString(Convert.ToInt32(value, 16),2));

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems.");

            konwersja("2A3E");
            konwersja("FA");
            konwersja("FFFF");
            konwersja("5A0E9");


            Console.ReadKey();
        }
    }
}
