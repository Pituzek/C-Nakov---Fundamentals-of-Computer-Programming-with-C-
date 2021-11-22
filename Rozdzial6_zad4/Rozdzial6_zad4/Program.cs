using System;

namespace Rozdzial6_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4. Write a program that prints all possible cards from a standard deck of cards, 
             * without jokers (there are 52 cards: 4 suits of 13 cards).
             */
            

            for (int i = 0; i < 4; i++)
            {
                if (i != 0) Console.WriteLine();

                for (int j = 0; j < 13; j++)
                {

                    switch(i)
                    {
                        case 0: Console.WriteLine("Kier"); break;
                        case 1: Console.WriteLine("Pik"); break;
                        case 2: Console.WriteLine("Trefl"); break;
                        case 3: Console.WriteLine("Karo"); break;
                    }

                    switch(j)
                    {
                        case 0: Console.WriteLine("2"); break;
                        case 1: Console.WriteLine("3"); break;
                        case 2: Console.WriteLine("4"); break;
                        case 3: Console.WriteLine("5"); break;
                        case 4: Console.WriteLine("6"); break;
                        case 5: Console.WriteLine("7"); break;
                        case 6: Console.WriteLine("8"); break;
                        case 7: Console.WriteLine("9"); break;
                        case 8: Console.WriteLine("10"); break;
                        case 9: Console.WriteLine("J"); break;
                        case 10: Console.WriteLine("Q"); break;
                        case 11: Console.WriteLine("K"); break;
                        case 12: Console.WriteLine("A"); break;
                    }





                }


                Console.ReadKey();


            }
        }
    }
}
