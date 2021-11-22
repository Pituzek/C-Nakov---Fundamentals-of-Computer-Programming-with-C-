using System;

namespace Rozdzial11_zad6
{
    class Program
    {
        static void TrzyBoki()
        {
            Console.Clear();

            Console.WriteLine("Podaj dlugosc boku a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj dlugosc boku b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj dlugosc boku c");
            double c = double.Parse(Console.ReadLine());

            double pole = (a + b + c) / 2;

            Console.WriteLine("\nPole trojkata wynosi: {0}", pole);
            Console.ReadKey();
        }

        static void BokWysokosc()
        {
            Console.Clear();

            Console.WriteLine("Podaj dlugosc boku a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokosc h");
            double h = double.Parse(Console.ReadLine());

            double pole = (a * h) / 2;

            Console.WriteLine("\nPole trojkata wynosi: {0}", pole);
            Console.ReadKey();

        }

        static void BokKat()
        {
            Console.Clear();

            Console.WriteLine("Podaj dlugosc boku a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj dlugosc boku b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj kat w stopniach");
            double kat = double.Parse(Console.ReadLine());

            kat *= Math.PI / 180;

            double pole = ((a * b * Math.Sin(kat)) / 2);

            Console.WriteLine("\nPole trojkata wynosi: {0}", pole);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            // - three sides;
            // - side and the altitude to it;
            // - two sides and the angle between them in degrees.

            int wybor;

            do 
            {
                Console.Clear();
                Console.WriteLine("Write a program which calculates the area of a triangle with the following given:");

                Console.WriteLine("\n1. Trzy boki");
                Console.WriteLine("2. Bok i wysokosc h");
                Console.WriteLine("3. Dwa boki i kat pomiedzy nimi");
                Console.WriteLine("4. Wyjscie");

                wybor = int.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        TrzyBoki();
                        break;
                    case 2:
                        BokWysokosc();
                        break;
                    case 3:
                        BokKat();
                        break;
                    case 4:
                        break;
                }

            } while (wybor != 4);

        }
    }
}
