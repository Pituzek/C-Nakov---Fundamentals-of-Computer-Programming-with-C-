using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad1
{
    class StudentH : Human, IComparable<StudentH>
    {
        private byte mark;

        public StudentH(string firstName, string lastName, byte mark) : base(firstName, lastName)
        {
            this.mark = mark;
        }

        public byte Mark
        {
            get { return this.mark; }
        }

        public int CompareTo(StudentH obj)
        {
            int comparsion = this.Mark.CompareTo(obj.Mark);
            return comparsion;
        }

        public override string ToString()
        {
            return "Imie: " + this.FirstName + " Nazwisko: " + this.LastName + " Ocena: " + this.Mark;
        }
    }
}
