using System;

namespace Rozdzial9_zad1
{
    class Program
    {

        static void WypiszImie(string twojeImie)
        {
            Console.WriteLine("Cześć {0}!", twojeImie);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. Write a code that by given name prints on the console \"Hello, < name > !\" (for example: \"Hello, Peter!\").");

            Console.WriteLine("Wpisz swoje imie");
            string imie = Console.ReadLine();

            WypiszImie(imie);

            Console.ReadKey();
        }
    }
}
