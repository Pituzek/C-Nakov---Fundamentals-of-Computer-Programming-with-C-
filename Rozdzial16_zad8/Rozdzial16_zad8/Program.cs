using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozdzial16_zad8
{
    class Program
    {
        public class NumberOfTimes
        {
            private int number;
            private int times;

            public NumberOfTimes()
            {
                this.number = 0;
                this.times = 0;
            }
            public NumberOfTimes(int Number, int Times)
            {
                this.number = Number;
                this.times = Times;
            }

            public int Number
            {
                get { return this.number; }
                set { this.number = value; }
            }

            public int Times
            {
                get { return this.times; }
                set { this.times = value; }
            }
        }

        static void Main(string[] args)
        {
            /*
             * 
             * 8. The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. ,
             * Write a program that finds the majorant of given array and prints it. If it does not exist, print "The majorant does not exist!".
               Example: {2, 2, 3, 3, 2, 3, 4, 3, 3} -> 3
             * 
             */
            Console.WriteLine("Hello World!");

            int n = int.Parse(Console.ReadLine());

            List<int> sequence = new List<int>();

            string[] nums = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach(var item in nums)
            {
                sequence.Add(int.Parse(item));
            }

            List<NumberOfTimes> nt = new List<NumberOfTimes>();

            foreach(var item in sequence)
            {
                bool flag = true;

                for( int i = 0; i < nt.Count; i++)
                {
                    if (item == nt[i].Number)
                    {
                        nt[i].Times++;
                        flag = false;
                    }
                }

                if(flag)
                {
                    nt.Add(new NumberOfTimes(item, 1));
                }

            }

            foreach( var item in nt)
            {
                if( item.Times >= n / 2 + 1)
                {
                    Console.WriteLine(item.Number);
                    break;
                }
            }


            Console.ReadKey();
        }
    }
}
