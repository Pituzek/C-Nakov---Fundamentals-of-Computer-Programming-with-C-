using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozdzial16_zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 9. We are given the following sequence:
            S1 = N;
            S2 = S1 + 1;
            S3 = 2*S1 + 1;
            S4 = S1 + 2;
            S5 = S2 + 1;
            S6 = 2*S2 + 1;
            S7 = S2 + 2;
            …
            Using the Queue<T> class, write a program which by given N prints on the console the first 50 elements of the sequence.
            Example: N=2 -> 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, …
             * 
             */
            Console.WriteLine("Podaj N");

            int n = int.Parse(Console.ReadLine());

            Queue<int> seq = new Queue<int>();

            seq.Enqueue(n);

            for ( int i = 1; i < 51; i++)
            {
                int temp = seq.Peek();

                if ( i % 3 == 1)
                {
                    seq.Enqueue(temp + 1);
                }
                else if ( i % 3 == 2)
                {
                    seq.Enqueue(2 * temp + 1);
                }
                else
                {
                    seq.Enqueue(temp + 2);
                    Console.Write("{0} ", seq.Dequeue());
                }

            }

            while(seq.Count != 0)
            {
                Console.Write("{0} ", seq.Dequeue());
            }



            Console.ReadKey();
        }
    }
}
