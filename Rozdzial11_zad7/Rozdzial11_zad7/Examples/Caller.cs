using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rozdzial11_zad7.Chapter11;

namespace Rozdzial11_zad7.Examples
{
    class Caller
    {
        static void Main(string[] args)
        {

            String name = "Cat";

            for (int i = 0; i < 10; i++)
            {
                Cat cat = new Cat(name + Sequence.NextValue(), "Black");
                cat.sayMiau();
            }
            Console.ReadLine();
        }
    }
}
