using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad1
{
    class SchoolClass
    {
        private List<Teacher> teacherList;
        private List<Student> studentList;
        private string classID;

        public SchoolClass(List<Teacher> teacherList, List<Student> studentList, string classID)
        {
            this.teacherList = teacherList;
            this.studentList = studentList;
            this.classID = classID;
        }


        public int GetStudentCount
        {
            get { return this.studentList.Count; }
        }

        public int GetTeacherCount
        {
            get { return this.teacherList.Count; }
        }

        public void AddStudent(string firstName, string lastName, int age, int uniqeID)
        {
            Student student = new Student(firstName, lastName, age, uniqeID);
            this.studentList.Add(student);
        }

        public void AddTeacher(string firstName, string lastName, int age)
        {
            Teacher teacher = new Teacher(firstName, lastName, age);
            this.teacherList.Add(teacher);
        }

        public override string ToString()
        {
            string result = "[" + this.classID + ": " + this.GetStudentCount + ": " + this.GetTeacherCount + "]";
            return result;
        }

        public List<Student> StudentList
        {
            get { return this.studentList; }
        }

        public List<Teacher> TeacherList
        {
            get { return this.teacherList; }
        }

    }
}

