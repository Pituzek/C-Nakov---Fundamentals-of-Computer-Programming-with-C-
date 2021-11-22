using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdzial11_zad7.Chapter11
{
    class Cat
    {
        private string name;
        private string color;

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void sayMiau()
        {
            Console.WriteLine("{0}: Miauu", name);
        }
    }
}
