using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad1
{
    class School
    {

        private List<SchoolClass> classOfStudents;

        public School()
        {
            this.classOfStudents = new List<SchoolClass>(); ;
        }

        public List<SchoolClass> ClassOfStudents
        {
            get { return this.classOfStudents; }
            set { this.classOfStudents = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var eachClass in this.ClassOfStudents)
            {
                result.AppendLine(eachClass.ToString());

                foreach (var eachStudent in eachClass.StudentList)
                {
                    result.AppendLine(eachStudent.ToString());
                }
                foreach (var eachTeacher in eachClass.TeacherList)
                {
                    result.AppendLine(eachTeacher.ToString());
                    foreach (var eachDiscipline in eachTeacher.Courses)
                    {
                        result.AppendLine(eachDiscipline.ToString());
                    }
                }
            }
            return result.ToString();
        }


    }
}
