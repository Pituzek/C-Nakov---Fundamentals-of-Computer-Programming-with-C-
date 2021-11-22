using System;

namespace Rozdzial4_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj promień R");
                
            double _r = double.Parse(Console.ReadLine());

            double pi = Math.PI;

            Console.WriteLine("Obwod kola wynosi: {0}", Obwod(_r, pi));
            Console.WriteLine("Pole kola wynosi: {0}", Pole(_r, pi));

        }

        static double Obwod(double promien, double _pi)
        {
            double obwod = 2 * _pi * promien;
            return obwod;
        }

        static double Pole(double promien, double _pi)
        {
            double pole = _pi * (Math.Pow(promien,2));
            return pole;
        }


    }
}
