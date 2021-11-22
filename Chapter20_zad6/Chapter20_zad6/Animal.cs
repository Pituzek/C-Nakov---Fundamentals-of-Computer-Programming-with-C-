using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad6
{
    public enum gender { male, female};
    class Animal
    {
        private int age;
        private string name;
        private gender gender;
        private string sound;

        public Animal(int age, string name, gender gender)
        {
            this.age = age;
            this.name = name;
            this.gender = gender;
        }

        public int Age
        {
            get { return this.age; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public gender Gender
        {
            get { return this.gender; }
        }

        public string Sound
        {
            get { return this.sound; }
            set { this.sound = value; }
        }
        protected virtual string GetAnimalSound()
        {
            return this.Sound;
        }

        public virtual void makeSound()
        {
            Console.WriteLine("Animal make sound");
        }

        public override string ToString()
        {
            string animalInf = String.Format("{0} {1} {2} {3}", this.name, this.age, this.gender, this.sound);
            return animalInf;
        }

    }
}
