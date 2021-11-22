using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad1
{
    class Course
    {

        private string courseName;
        private int classesCount;
        private int exercisesCount;

        public Course(string courseName, int classesCount, int exercisesCount)
        {
            this.courseName = courseName;
            this.classesCount = classesCount;
            this.exercisesCount = exercisesCount;
        }

        public string CourseName
        {
            get { return this.courseName; }
        }
        public int ClassesCount
        {
            get { return this.classesCount; }
        }
        public int ExercisesCount
        {
            get { return this.exercisesCount; }
        }

        public override string ToString()
        {
            string result = "[" + this.CourseName + " : " + this.ClassesCount + " : " + this.ExercisesCount;
            return result;
        }

    }
}
