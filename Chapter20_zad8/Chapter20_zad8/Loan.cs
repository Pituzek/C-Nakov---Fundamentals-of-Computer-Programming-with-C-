using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad8
{
    class Loan : Account
    {

        public Loan(Customer accountOwner, decimal accountBalance, decimal interestRateByMonth) : base(accountOwner, accountBalance, interestRateByMonth)
        {

        }

        public override decimal CalculateMonthlyInterest(uint numberOfMonths)
        {
            // Loan accounts have no interest rate during the first 3 months if held by individuals and during the first 2 months if held by a company.

            byte noInterestPeriodInMonth = 0;
            if (this.AccountOwner.TypeOfCustomer == CustomerType.Individual)
            {
                noInterestPeriodInMonth = 3;
            }
            else
            {
                noInterestPeriodInMonth = 2;
            }

            decimal interest = 0.0M;
            if (numberOfMonths <= noInterestPeriodInMonth)
            {
                return interest;
            }
            else
            {
                numberOfMonths -= noInterestPeriodInMonth;
                interest = this.InterestRateByMonth * numberOfMonths;
                return interest;
            }

        }

    }
}
