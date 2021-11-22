using System;

namespace Rozdzial9_zad11
{
    class Program
    {
        static void Odwroc(int n)
        {
            int reverse = 0, rem;

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Odwrocona liczba: " + reverse);
        }

        static void ObliczSrednia(int[] tablica)
        {
            decimal srednia = 0;
            int licznik = 0;

            for (int i = 0; i < tablica.Length; i++)
            {
                srednia += tablica[i];
                licznik++;
            }

            srednia = srednia / licznik;

            Console.WriteLine("Srednia= {0}", srednia);

        }

        static void RozwiazRown()
        { 
            int a = 0;

            do
            {
                Console.Clear();
                Console.Write("Podaj a: (rozne od 0)");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);

            Console.Write("Podaj b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("x = {0}", (float)-b/a);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("11. Write a program that solves the following tasks:");
            /*
            - Put the digits from an integer number into a reversed order.
            - Calculate the average of given sequence of numbers.
            - Solve the linear equation a *x + b = 0.
                Create appropriate methods for each of the above tasks.
                Make the program show a text menu to the user.
                By choosing an option of that menu, the user will be able to choose which task 
                to be invoked.
         
                
            Perform validation of the input data:
            - The integer number must be a positive in the range[1…50, 000, 000].
            - The sequence of numbers cannot be empty.
            - The coefficient a must be non - zero.
            */

            int wybor = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Put the digits from an integer number into a reversed order.");
                Console.WriteLine("2. Calculate the average of given sequence of numbers.");
                Console.WriteLine("3. Solve the linear equation a* x +b = 0.");
                Console.WriteLine("4. Wyjscie");
                wybor = int.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        Console.WriteLine("Wpisz liczbe n");
                        int n = int.Parse(Console.ReadLine());
                        Odwroc(n);
                        break;

                    case 2:
                        Console.WriteLine("Podaj wielkosc tablicy");
                        int x = int.Parse(Console.ReadLine());
                        int[] tab = new int[x];

                        for (int i = 0; i < x; i++)
                        {
                            Console.WriteLine("Element{0} =", i);
                            tab[i] = int.Parse(Console.ReadLine());
                        }

                        ObliczSrednia(tab);
                        break;

                    case 3:

                        RozwiazRown(); //dla czytelnosci programu, lepiej wszystkie dane umiescic w metodzie
                        break;
                }
            }
            while (wybor != 4);

            Console.ReadKey();

        }
    }
}
