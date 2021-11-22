using System;
using System.Collections.Generic;
using System.Linq;

namespace Rozdzial22_zad3_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Write a class Student with the following properties: first name, last name and age.
            //Write a method that for a given array of students finds those, whose first name is before their last one in alphabetical order.
            //Use LINQ.

            List<Student> studentsList = new List<Student>();
            Student jKowalski = new Student("Jan", "Kowalski", 22);
            Student aKowalski = new Student("Anna", "Kowalski", 17);
            Student kGrzebyk = new Student("Kamil", "Grzebyk", 26);
            Student bGrzebyk = new Student("Basia", "Grzebyk", 24);
            Student jJ = new Student("Jan", "J", 28);

            studentsList.Add(kGrzebyk);
            studentsList.Add(jKowalski);
            studentsList.Add(bGrzebyk);
            studentsList.Add(aKowalski);
            studentsList.Add(jJ);

            var a =
                from name in studentsList
                where name.FirstName.CompareTo(name.LastName) < 0
                orderby name.FirstName
                select name;

            // pomija Kamil Grzebyk, poniewaz K jest po G w alfabecie
            foreach (var s in a)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName);
            }

            //zad 4. Create a LINQ query that finds the first and the last name of all students,
            //aged between 18 and 24 years including. Use the class Student from the previous exercise.

            var b =
                from student in studentsList
                where (student.StudentAge > 18 && student.StudentAge <= 24)
                orderby student.FirstName, student.LastName
                select student;

            foreach (var s in b)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.StudentAge);
            }

            //zad 5. By using the extension methods OrderBy(…) and ThenBy(…) with lambda expression,
            //sort a list of students by their first and last name in descending order.
            //Rewrite the same functionality using a LINQ query.

            // klasa StudentsSort
            Console.WriteLine("");

            var test = StudentsSort.GetSortedStudentsCollection(studentsList);
            foreach (var s in test)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.StudentAge);
            }




            Console.ReadKey();
        }
    }

    //ZAD 6. Write a program that prints to the console all numbers from a given array (or list),
    //that are multiples of 7 and 3 at the same time. Use the built-in extension methods with lambda
    //expressions and then rewrite the same using a LINQ query.
    public static partial class IEnumerableExt
    {
        public static IEnumerable<T> GetDivisibleBySevenThree<T>(this IEnumerable<T> collection, bool useParallel = false)
        {
            if (useParallel)
            {
                collection = collection.AsParallel();
            }

            return collection.Where(x => (dynamic)x % 21 == 0).OrderBy(x => x);
        }

        public static IEnumerable<T> GetDivisibleBySevenThreeLinq<T>(this IEnumerable<T> collection, bool useParallel = false)
        {
            if (useParallel)
            {
                collection = collection.AsParallel();
            }

            return from x in collection
                   where (dynamic)x % 21 == 0
                   orderby x
                   select x;
        }
    }

}
