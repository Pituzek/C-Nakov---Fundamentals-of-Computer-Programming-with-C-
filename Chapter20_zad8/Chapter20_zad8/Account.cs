using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad8
{
    abstract class Account
    {
        private Customer accountOwner;
        private decimal accountBalance;
        private decimal interestRateByMonth;

        public Account(Customer accountOwner, decimal accountBalance, decimal interestRateByMonth)
        {
            this.accountOwner = accountOwner;
            this.accountBalance = accountBalance;
            this.interestRateByMonth = interestRateByMonth;
        }

        public Customer AccountOwner
        {
            get { return this.accountOwner; }
        }

        public decimal AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public decimal InterestRateByMonth
        {
            get { return this.interestRateByMonth; }
        }

        public abstract decimal CalculateMonthlyInterest(uint numberOfMonths);

        public virtual void DepositMoney(decimal amount)
        {
            this.accountBalance += amount;
        }
    }
}
