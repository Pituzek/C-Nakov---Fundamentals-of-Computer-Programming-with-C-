using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad8
{
    class Deposit : Account
    {

        public Deposit(Customer accountOwner, decimal accountBalance, decimal interestRateByMonth) : base(accountOwner, accountBalance, interestRateByMonth)
        {
        }

        public override decimal CalculateMonthlyInterest(uint numberOfMonths)
        {
            decimal interest = 0.0M;
            // Deposit accounts have no interest rate if their balance is positive and less than 1000.
            if (this.AccountBalance >= 0 && this.AccountBalance < 1000 )
            {
                return interest;
            }
            else
            {
                interest = this.InterestRateByMonth * numberOfMonths;
                return interest;
            }
        }

        public void WithdrawMoney(decimal amount)
        {
            StringBuilder message = new StringBuilder();

            if (amount <= this.AccountBalance)
            {
                this.AccountBalance -= amount;
                message.Append("money withdrawn from account");
                Console.WriteLine("{0} {1}", amount, message.ToString());
            }
            else
            {
                message.Append("Not enough balance");
                Console.WriteLine(message.ToString());
            }
        }

    }
}
