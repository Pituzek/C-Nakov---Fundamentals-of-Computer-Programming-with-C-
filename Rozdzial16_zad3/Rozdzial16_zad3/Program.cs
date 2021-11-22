using System;
using System.Collections.Generic;
using System.Linq;

namespace Rozdzial16_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. Write a program that reads from the console a sequence of positive integer numbers." +
                " The sequence ends when an empty line is entered. Print the sequence sorted in ascending order.");

            string line;
            List<int> num = new List<int>();

            while((line = Console.ReadLine()) != "")
            {
                num.Add(int.Parse(line));  
            }
            
            int[] arr = num.ToArray(); // tu wystarczy num.Sort();
            Array.Sort(arr);

            num = arr.ToList<int>();

            Console.WriteLine("");

            foreach(var liczba in num)
            {
                Console.WriteLine(liczba);
            }    

            Console.ReadKey();
        }
    }
}
