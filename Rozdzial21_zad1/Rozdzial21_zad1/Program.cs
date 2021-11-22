using System;
using System.Collections.Generic;
using System.Text;

namespace Rozdzial21_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Take the code from the first example in this chapter and refactor it to meet the quality standards discussed in this chapter.

            int switchValue = 5;
            int numberOfIterations = 5;
            int number;

            switch (switchValue)
            {
                case 10:
                    {
                        number = 5;
                        PrintText(number);
                        break;
                    }

                case 9:
                    {
                        numberOfIterations = 0;
                        break;
                    }

                case 8:
                    {
                        PrintText("We are in case 8");
                        break;
                    }

                default:
                    {
                        PrintText(" Default case");
                        PrintText("hoho ");
                        for (int k = 0; k < numberOfIterations; k++)
                        {
                            PrintText(k - 'f');
                        }
                        break;
                    }
            }

            PrintText("We finished the switch case loop!");

            Console.ReadKey();
        }

        public static void PrintText<T> (T text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            Console.WriteLine(sb.ToString());
        }
    }
}
