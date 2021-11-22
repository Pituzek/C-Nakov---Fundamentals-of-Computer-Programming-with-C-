using System;
using System.Collections.Generic;

namespace Chapter20_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. We are given a school. The school has classes of students.
            //Each class has a set of teachers.
            //Each teacher teaches a set of courses.
            //The students have a name and unique number in the class.
            //Classes have a unique text identifier.
            //Teachers have names.
            //Courses have a name, count of classes and count of exercises.
            //The teachers as well as the students are people.
            //Your task is to model the classes (in terms of OOP) along with their attributes and
            //operations define the class hierarchy and create a class diagram with Visual Studio.


            //2. Define a class Human with properties "first name" and "last name".
            //Define the class Student inheriting Human, which has the property "mark".
            //Define the class Worker inheriting Human with the property "wage" and "hours worked".
            //Implement a "calculate hourly wage" method, which calculates a worker’s hourly pay rate based on wage and hours worked.
            //Write the corresponding constructors and encapsulate all data in properties.

            //3. Initialize an array of 10 students and sort them by mark in ascending order. Use the interface System.IComparable<T>.

            //4. Initialize an array of 10 workers and sort them by salary in descending order.

            Console.WriteLine("Zad1");

            School school = new School();

            Student s1 = new Student("Anna", "Kowalska", 22, 01);
            Student s2 = new Student("Krzysztof", "Kowalski", 25, 02);
            Student s3 = new Student("Anna", "Czubówna", 20, 03);

            Teacher t1 = new Teacher("Zdzisiu", "Brzeczyszczykiewicz", 55);
            t1.AddNonExistingCourse("Biologia", 3, 2);

            Course Matma = new Course("Matematyka", 5, 5);

            t1.AddExistingCourse(Matma);


            List<Student> studentsClassK1 = new List<Student>();
            studentsClassK1.Add(s1);
            studentsClassK1.Add(s2);
            studentsClassK1.Add(s3);

            List<Teacher> teachersClassK1 = new List<Teacher>();
            teachersClassK1.Add(t1);

            SchoolClass klasa1 = new SchoolClass(teachersClassK1, studentsClassK1, "Klasa C");


            foreach (var student in klasa1.StudentList)
            {
                Console.WriteLine(student.ToString());
            }

            foreach (var teacher in klasa1.TeacherList)
            {
                Console.WriteLine(teacher.ToString());
            }

            Console.WriteLine(klasa1.ToString());

            Console.WriteLine("Zad 2");

            Worker w1 = new Worker("Jan", "Kowalski", 20, 8);
            Worker w2 = new Worker("Tadeusz", "P", 50, 8);

            Console.WriteLine(w1.CalculateHourlyWage()); //
            Console.WriteLine(w1.CalculateHourlyWage(w2)); // poprzednia metoda lepsza

            Console.WriteLine(CalculateHourlyWage2(w1));
            Console.WriteLine(CalculateHourlyWage2(w2));

            Worker w3 = new Worker("n", "k", 15, 4);
            Console.WriteLine(CalculateHourlyWage2(w3));

            Program p = new Program(); // wywolanie metody non-static, z metody static wymaga zainicjalizowania klasy (ew mozna zmienic metode na static)
            Console.WriteLine(p.CalculateHourlyWage3(w3));


            Console.WriteLine("Zad 3");

            StudentH ss1 = new StudentH("Artur", "B", 4);
            StudentH ss2 = new StudentH("Adam", "B", 5);
            StudentH ss3 = new StudentH("Andrzej", "B", 3);
            StudentH ss4 = new StudentH("Alojzy", "B", 2);
            StudentH ss5 = new StudentH("Grzegorz", "B", 1);
            StudentH ss6 = new StudentH("Krzysztof", "B", 1);
            StudentH ss7 = new StudentH("Piotr", "B", 3);
            StudentH ss8 = new StudentH("Paweł", "B", 5);
            StudentH ss9 = new StudentH("Michał", "B", 6);
            StudentH ss10 = new StudentH("Rafał", "B", 2);

            StudentH[] zbiorStud = { ss1, ss2, ss3, ss4, ss5, ss6, ss7, ss8, ss9, ss10 };

            Array.Sort(zbiorStud);

            foreach (var stud in zbiorStud)
            {
                Console.WriteLine(stud.ToString()) ;
            }

       

            Console.ReadLine();
        }

        public static decimal CalculateHourlyWage2(Worker w)
        {
            var hours = w.HoursWorked;
            var pay = w.Wage;

            var placa = hours * pay;

            return placa;
        }

        public decimal CalculateHourlyWage3(Worker w)
        {
            var hours = w.HoursWorked;
            var pay = w.Wage;

            var placa = hours * pay;

            return placa;
        }
    }
}
