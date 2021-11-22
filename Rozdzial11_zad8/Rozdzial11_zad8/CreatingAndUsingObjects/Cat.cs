using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdzial11_zad8.CreatingAndUsingObjects
{
    class Cat
    {
        private string name;
        private string color;
        private string nazwalosowa;

        public Cat(string name, string color, string nazwalosowa)
        {
            this.name = name;
            this.color = color;
            this.nazwalosowa = nazwalosowa;
        }

        public void sayMiau()
        {
            Console.WriteLine("{0} {1}: Miauu", name, nazwalosowa);
        }

    }
}
