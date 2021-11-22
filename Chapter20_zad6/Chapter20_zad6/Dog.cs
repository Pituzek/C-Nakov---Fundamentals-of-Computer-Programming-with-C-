using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad6
{
    class Dog : Animal
    {
        public Dog(int age, string name, gender gender) : base(age, name, gender)
        {
            this.Sound = "Bark";
        }

        public override void makeSound()
        {
            Console.WriteLine("Bark");
        }

        protected override string GetAnimalSound()
        {
            return this.Sound;
        }


    }
}
