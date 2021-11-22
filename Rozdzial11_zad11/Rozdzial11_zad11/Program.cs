using System;

namespace Rozdzial11_zad11
{
    class Program
    {

        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("11. Write a program, which generates a random advertising message for some product. The message has to consist of laudatory phrase, followed by a laudatory story, followed by author (first and last name) and city, which are selected from predefined lists. For example, let’s have the following lists:");
            
            /*
                - Laudatory phrases: {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."}.
                - Laudatory stories: {"Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."}.
                - First name of the author: {"Dayan", "Stella", "Hellen", "Kate"}.
                - Last name of the author: {"Johnson", "Peterson", "Charls"}.
                - Cities: {"London", "Paris", "Berlin", "New York", "Madrid"}.
             Then the program would print randomly generated advertising message like the following:
             I use this product constantly. You should try it, too. I am very satisfied. -- Hellen Peterson, Berlin
             */

            string[] laudPhrases = { "The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category." };
            string[] laudStories = { "Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied." };
            string[] firstName = { "Dayan", "Stella", "Hellen", "Kate" };
            string[] lastName = { "Johnson", "Peterson", "Charls" };
            string[] cities = { "London", "Paris", "Berlin", "New York", "Madrid" };

            Console.WriteLine("\n" + laudPhrases[rnd.Next(0,laudPhrases.Length)] + " " + laudStories[rnd.Next(0, laudStories.Length)] + " -- " + firstName[rnd.Next(0, firstName.Length)] + " " + lastName[rnd.Next(0, lastName.Length)] + ", " + cities[rnd.Next(0,cities.Length)]);

            Console.ReadKey();
        }
    }
}
