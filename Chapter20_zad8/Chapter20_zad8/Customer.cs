using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad8
{
    public enum CustomerType { Individual, Company };
    class Customer
    {
        private CustomerType typeOfCustomer;
        private string name;
        public Customer (CustomerType typeOfCustomer, string name)
        {
            this.typeOfCustomer = typeOfCustomer;
            this.name = name;
        }

        public CustomerType TypeOfCustomer
        {
            get { return this.typeOfCustomer; }
        }

        public string Name
        {
            get { return this.name; }
        }

    }
}
