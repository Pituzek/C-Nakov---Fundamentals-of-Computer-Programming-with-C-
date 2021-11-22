using System;

namespace Chapter20_zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Implement the following classes: Dog, Frog, Cat, Kitten and Tomcat.
            //All of them are animals (Animal). Animals are characterized by age, name and gender.
            //Each animal makes a sound (use a virtual method in the Animal class).
            //Create an array of different animals and print on the console their name, age and the corresponding sound each one makes.

            //7. Using Visual Studio generate the class diagrams of the classes from the previous task with it.

            Console.WriteLine("Hello World!");

            Frog frog = new Frog(1, "Frogger", gender.male);
            Dog dog = new Dog(5, "Sophie", gender.female);
            Kitten kitten = new Kitten(2, "Kitkat", gender.male);
            Tomcat tomcat = new Tomcat(6, "Tom", gender.male);

            Animal[] animals = {frog, dog, kitten, tomcat };

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].ToString());
                animals[i].makeSound();
            }

            Console.ReadKey();
        }
    }
}
