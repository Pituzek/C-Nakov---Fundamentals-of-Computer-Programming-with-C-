using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad6
{
    class Frog : Animal
    {
        public Frog(int age, string name, gender gender) : base(age, name, gender)
        {
            this.Sound = "Ribbit";
        }

        public override void makeSound()
        {
            Console.WriteLine("Ribbit");
        }

        protected override string GetAnimalSound()
        {
            return this.Sound;
        }


    }
}
