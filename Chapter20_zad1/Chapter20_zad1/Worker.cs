using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad1
{
    class Worker : Human, IComparable<Worker>
    {
        private decimal wage;
        private byte hoursWorked;

        public Worker(string firstName, string lastName, decimal wage, byte hoursWorked) : base(firstName, lastName)
        {
            this.wage = wage;
            this.hoursWorked = hoursWorked;
        }

        public decimal CalculateHourlyWage(Worker w)
        {
            var hours = w.HoursWorked;
            var pay = w.Wage;

            var placa = hours * pay;

            return placa;
        }

        public decimal CalculateHourlyWage()
        {
            decimal salary = this.wage * this.hoursWorked;
            return salary;
        }

        public int CompareTo(Worker other)
        {
            int comparsion = other.CalculateHourlyWage().CompareTo(this.CalculateHourlyWage());
            return comparsion;
        }

        public decimal Wage
        {
            get { return this.wage; }
        }

        public byte HoursWorked
        {
            get { return this.hoursWorked; }
        }

    }
}
