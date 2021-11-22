using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad8
{
    class Mortgage : Account
    {
        public Mortgage(Customer accountOwner, decimal accountBalance, decimal interestRateByMonth) : base(accountOwner, accountBalance, interestRateByMonth)
        {

        }

        public override decimal CalculateMonthlyInterest(uint numberOfMonths)
        {
            // Mortgage accounts have ½ the interest rate during the first 12 months for companies and no interest rate during the first 6 months for individuals.
            decimal interest = 0.0M;
            if (this.AccountOwner.TypeOfCustomer == CustomerType.Individual)
            {
                interest = CalculateIndividualInterestRateByMonth(numberOfMonths);
            }
            else
            {
                interest = CalculateCompanyInterestRateByMonth(numberOfMonths);
            }

            return interest;
        }

        public decimal CalculateIndividualInterestRateByMonth(uint numberOfMonths)
        {
            byte noInterestRateInMonths = 6;
            decimal interest = 0.0M;
            if (numberOfMonths <= noInterestRateInMonths)
            {
                return interest;
            }
            else
            {
                numberOfMonths -= noInterestRateInMonths;
                interest = this.InterestRateByMonth * numberOfMonths;
                return interest;
            }
        }

        public decimal CalculateCompanyInterestRateByMonth(uint numberOfMonths)
        {
            byte halfInterestRatePeriodInMonth = 12;
            decimal interest = 0.0M;
            if (numberOfMonths <= halfInterestRatePeriodInMonth)
            {
                interest = (this.InterestRateByMonth / 2) * numberOfMonths;
                return interest;
            }
            else
            {
                numberOfMonths -= halfInterestRatePeriodInMonth;
                interest = ((this.InterestRateByMonth / 2) * halfInterestRatePeriodInMonth
                    + this.InterestRateByMonth * numberOfMonths);
                return interest;
            }
        }
    }
}
