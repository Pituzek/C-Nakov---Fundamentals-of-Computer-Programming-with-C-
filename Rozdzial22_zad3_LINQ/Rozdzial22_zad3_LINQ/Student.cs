using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdzial22_zad3_LINQ
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int studentAge;

        public Student(string firstName, string lastName, int studentAge)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentAge = studentAge;
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public int StudentAge
        {
            get { return this.studentAge; }
        }

    }
}
