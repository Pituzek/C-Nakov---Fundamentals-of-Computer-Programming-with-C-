﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad6
{
    class Tomcat : Animal
    {
        public Tomcat(int age, string name, gender gender) : base(age, name, gender)
        {
            this.Sound = "Meow meow!";
        }

        public override void makeSound()
        {
            Console.WriteLine("Meow meow!");
        }

        protected override string GetAnimalSound()
        {
            return this.Sound;
        }


    }
}
