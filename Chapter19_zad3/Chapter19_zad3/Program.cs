using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Chapter19_zad3
{
    class Student
    {
        private string firstName;
        private string lastName;

        public Student(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //3.It is given a text file students.txt containing information about students and their specialty in the following format:
            /*
                Steven Davis | Computer Science
                Joseph Johnson | Software Engeneering
                Helen Mitchell | Public Relations
                Nicolas Carter | Computer Science
                Susan Green | Public Relations
                William Johnson | Software Engeneering

            Using SortedDictionary<K, T> print on the console the specialties in an alphabetical order and for each of them print the names of the students,
            firstly sorted by family name and secondly – by first name, as shown:

                Computer Sciences: Nicolas Carter, Steven Davis
                Public Relations: Susan Green, Helen Mitchell
                Software Engeneering: Joseph Johnson, William Johnson
            */

            StreamReader reader = new StreamReader("in.1.txt");
            SortedDictionary<string, List<Student>> students = new SortedDictionary<string, List<Student>>();

            using (reader)
            {
                string line = reader.ReadLine();

                while(line != null)
                {
                    string[] studentInfo = line.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    Student newStudent = new Student(studentInfo[0], studentInfo[1]);

                    if (!students.ContainsKey(studentInfo[2]))
                    {
                        students.Add(studentInfo[2], new List<Student>() { newStudent });
                        line = reader.ReadLine();
                        continue;
                    }

                    students[studentInfo[2]].Add(newStudent);
                    line = reader.ReadLine();
                }
            }

            var subjects = students.Keys;

            StringBuilder result = new StringBuilder();

            foreach ( var studentsInSubjects in subjects)
            {
                List<Student> listOfStudents = students[studentsInSubjects];
                var sortedStudents = listOfStudents.OrderBy(x => x.LastName);

                result.Append(studentsInSubjects + ":");

                foreach ( var student in sortedStudents)
                {
                    result.Append(" " + student.FirstName + " " + student.LastName+",");
                }
                result.Remove(result.Length - 1, 1);
                result.AppendLine();
            }
            result.Remove(result.Length - 1, 1);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
