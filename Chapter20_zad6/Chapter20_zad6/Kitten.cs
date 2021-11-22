using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad6
{
    class Kitten : Animal
    {
        public Kitten(int age, string name, gender gender) : base(age, name, gender)
        {
            this.Sound = "Meow";
        }

        public override void makeSound()
        {
            Console.WriteLine("Meow");
        }

        protected override string GetAnimalSound()
        {
            return this.Sound;
        }


    }
}
