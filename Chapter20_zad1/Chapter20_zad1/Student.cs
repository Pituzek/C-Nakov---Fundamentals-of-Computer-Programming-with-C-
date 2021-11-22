using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad1
{
    class Student : Person
    {
        private int uniqeID;

        public Student(string firstName, string lastName, int age, int uniqeID) : base(firstName, lastName, age)
        {
            this.uniqeID = uniqeID;
        }

        public int UniqeID
        {
            get { return this.uniqeID; }
            set { this.uniqeID = value; }
        }

        public override string ToString()
        {
            string result = "[" + this.FirstName + " " + this.LastName + ":" + " " + this.uniqeID + "]";
            return result;
        }

    }

}
