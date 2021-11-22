using System;
// dodane odwolanie do nowo stworzonego folderu, czyli namespace to nazwa naszego folderu
using Rozdzial11_zad8.CreatingAndUsingObjects;

namespace Rozdzial11_zad8
{
    class Program
    {

        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("8. Write a program which creates 10 objects of type Cat, gives them names CatN, where N is a unique serial number of the object, and in the end call the method SayMiau() for each of them. For the implementation use the namespace CreatingAndUsingObjects.");

            string name = "Cat";

            string[] nazwy = {"Pysio", "Puszek", "Mruczek", "Misio", "Tymek" };

            Cat[] kot = new Cat[10];

            /* tworzenie tablic z klas
            Subject[] subjects = new Subject[2];
            subjects[0] = new Subject { .... };
            subjects[1] = new Subject { .... };
            */

            int index = 0;

            for (int i = 0; i < 10; i++)
            {
                index = rnd.Next(nazwy.Length);
                kot[i] = new Cat(name + Sequence.NextValue(), "test", nazwy[index]);
            }

            foreach(Cat koty in kot)
            {
                koty.sayMiau();
            }

            Console.ReadKey();
        }
    }
}
