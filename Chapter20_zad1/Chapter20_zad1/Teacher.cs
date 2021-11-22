using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad1
{
    class Teacher : Person
    {
        //private Courses course;
        private List<Course> courses;

        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            this.courses = new List<Course>(); ;
        }

        public List<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public int CoursesCount
        {
            get { return this.courses.Count; }
        }

        public void AddNonExistingCourse(string courseName, int classesCount, int exercisesCount)
        {
            Course course = new Course(courseName, classesCount, exercisesCount);
            this.courses.Add(course);
        }

        public void AddExistingCourse(Course course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            string result = "[" + this.FirstName + " " + this.LastName + " : " + this.CoursesCount + "]"; 
            return result;
        }

    }
}
