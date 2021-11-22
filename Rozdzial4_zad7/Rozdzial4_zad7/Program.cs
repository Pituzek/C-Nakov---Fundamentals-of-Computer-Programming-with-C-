using System;

namespace Rozdzial4_zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 7. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.
             */
            Console.WriteLine("Podaj 5 liczb całkowitych");

            int[] liczby = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Podaj {0} liczbe", i);
                string input = Console.ReadLine();

                
                bool isInteger = int.TryParse(input, out liczby[i]);

                if (isInteger == false)
                {
                    Console.WriteLine("Podaj inna liczbe");
                    i--;
                    continue;
                }
                else
                {
                    //sum += integerInput;

                }

            }

            int integerInput = 0;

            foreach (int cos in liczby)
            {
                integerInput += cos;
            }

            Console.WriteLine("Suma= {0}", integerInput);

            Console.ReadKey();





        }
    }
}
