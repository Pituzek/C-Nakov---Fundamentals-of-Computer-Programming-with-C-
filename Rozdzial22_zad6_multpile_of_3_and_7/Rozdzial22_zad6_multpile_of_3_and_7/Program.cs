using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Rozdzial22_zad6_multpile_of_3_and_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Write a program that prints to the console all numbers from a given array (or list),
            //that are multiples of 7 and 3 at the same time. Use the built-in extension methods
            //with lambda expressions and then rewrite the same using a LINQ query.

            List<int> listaLiczb = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 21, 24, 42, 48, 63 };

            var a = IEnumberableExt.GetDivisbleByThreeAndSeven(listaLiczb);
            var b = IEnumberableExt.GetDivisibleByThreeAndSevenLinq(listaLiczb);

            foreach (int x in a)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("");

            foreach (int x in b)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }

    public static partial class IEnumberableExt
    {
        public static IEnumerable<T> GetDivisbleByThreeAndSeven<T>(this IEnumerable<T> collection, bool useParallel = false)
        {
            if (useParallel)
            {
                collection = collection.AsParallel();
            }
            return collection.Where(x => (dynamic)x % 21 == 0).OrderBy(x => x);
        }

        public static IEnumerable<T> GetDivisibleByThreeAndSevenLinq<T>(this IEnumerable<T> collection, bool useParallel = false)
        {
            if (useParallel)
            {
                collection = collection.AsParallel();
            }
            var test = from x in collection
                       where (dynamic)x % 21 == 0
                       orderby x
                       select x;
            return test;
        }


    }

}
