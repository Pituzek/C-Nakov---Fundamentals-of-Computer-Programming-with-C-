using System;
using System.Text;
namespace Rozdzial13_zad3
{
    class Program
    {
        static int checkParentheses(int licznik, string s)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(s);

            int counter = licznik;

            for (int i = 0; i < sb.Length; i++)
            {
                //Console.WriteLine(sb[i]);
                if (sb[i].Equals('('))
                {
                    counter += 1;
                }
                else if (sb[i].Equals(')'))
                {
                    counter -= 1;
                }
                else if (counter < 0)
                {
                    //Console.WriteLine("DUH!");
                    break;

                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("3. Write a program that checks whether the parentheses are placed correctly in an arithmetic expression. Example of expression with correctly placed brackets: ((a+b)/5-d). Example of an incorrect expression: )(a+b)).");

            string rown = "((a+b)/5-d)";
            int licznik = 0;

            int count = checkParentheses(licznik, rown);

            if (count < 0 || count > 0)
            {
                Console.WriteLine("\nParentheses are placed incorrectly");
            }
            else
            {
                Console.WriteLine("\nParentheses are placed correctly");
            }

            Console.ReadKey();
        }
    }
}
