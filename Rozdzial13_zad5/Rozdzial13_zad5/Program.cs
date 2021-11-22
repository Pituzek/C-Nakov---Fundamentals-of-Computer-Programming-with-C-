using System;

namespace Rozdzial13_zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5. Write a program that detects how many times a substring is contained in the text. For example, let’s look for the substring \"in \" in the text:");

            string keyword = "in";
            string quote = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            quote = quote.ToLower();

            int index = quote.IndexOf(keyword);
            int counter = 1; // pierwszy znaleziony znak

            while(index != -1)
            {
                index = quote.IndexOf(keyword, index+1);
                if (index != -1) counter++;
            }

            Console.WriteLine(counter);

            Console.ReadKey();
        }
    }
}
