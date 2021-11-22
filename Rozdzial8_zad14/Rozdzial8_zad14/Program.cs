using System;

namespace Rozdzial8_zad14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14. Try adding up 50,000,000 times the number 0.000001. Use a loop and addition (not direct multiplication). Try it with float and double and after that with decimal. Do you notice the huge difference in the results and speed of calculation? Explain what happens.");

            decimal sum = 0.0m;
            for (int i = 1; i <= 50000000.0; i++)
            {
                sum += 0.000001m;
            }
            Console.WriteLine("{0}", sum);

            Console.ReadKey();
        }
    }
}
