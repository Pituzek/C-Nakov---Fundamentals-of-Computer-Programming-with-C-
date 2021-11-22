using System;
using System.Collections.Generic;

namespace Rozdzial16_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. Write a program, which reads from the console N integers and prints them in reversed order. Use the Stack<int> class.");

            Console.WriteLine("Podaj ilosc liczb calkowitych");
            int n = int.Parse(Console.ReadLine());

            string[] numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Stack<int> stack = new Stack<int>();
            for(int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(numbers[i]));
            }

            while(stack.Count > 1)
            {
                Console.Write("{0} ",stack.Pop());
            }
            Console.WriteLine(stack.Pop());



            Console.ReadKey();
        }
    }
}
