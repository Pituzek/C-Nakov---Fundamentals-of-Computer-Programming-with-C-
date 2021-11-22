using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad8
{
    class Bank
    {
        static void Main(string[] args)
        {
            // 8. A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
            // Customers can be individuals or companies.
            // All accounts have a customer, balance and interest rate (monthly based).
            // Deposit accounts allow depositing and withdrawing of money.
            // Loan and mortgage accounts allow only depositing.
            // All accounts can calculate their interest for a given period (in months).
            // In the general case, it is calculated as follows: number_of_months * interest_rate.
            // Loan accounts have no interest rate during the first 3 months if held by individuals and during the first 2 months if held by a company.
            // Deposit accounts have no interest rate if their balance is positive and less than 1000.
            // Mortgage accounts have ½ the interest rate during the first 12 months for companies and no interest rate during the first 6 months for individuals.
            // Your task is to write an object-oriented model of the bank system.
            // You must identify the classes, interfaces,
            // base classes and abstract actions and implement the interest calculation functionality.
            ReadAccounts();
            Console.ReadKey();
        }

        static string ReadAccounts()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int currAcc = 0; currAcc < n; currAcc++)
            {
                string account = Console.ReadLine();
                string interestRate = IdentifyAccount(account);
                result.Append(interestRate);
            }
            return result.ToString();
        }

        static string IdentifyAccount(string account)
        {
            // nazwa_klienta typ_konta typ_klienta stan_konta interest_rate months 
            string[] details = account.Split();
            string customerName = details[0];
            string accountType = details[1] + " " + details[2];
            string customerType = details[2];
            decimal balance = decimal.Parse(details[3]);
            decimal interestRate = decimal.Parse(details[4]);
            uint months = uint.Parse(details[5]);
            string output = string.Empty;
            switch (accountType)
            {
                case "deposit individual":
                case "deposit company":
                    {
                        output = GetDepositRate(customerName, customerType, balance, interestRate, months);
                        break;
                    }
                case "loan individual":
                    {
                        output = GetIndividualLoanRate(customerName, customerType, balance, interestRate, months);
                        break;
                    }
                case "loan company":
                    {
                        output = GetCompanyLoanRate(customerName, customerType, balance, interestRate, months);
                        break;
                    }
                case "mortgage individual":
                    {
                        output = GetIndividualMortgageRate(customerName, customerType, balance, interestRate, months);
                        break;
                    }
                case "mortgage company":
                    {
                        output = GetCompanyMortgageRate(customerName, customerType, balance, interestRate, months);
                        break;
                    }
                default:
                    throw new ArgumentException(
           "Unrecognized account: {0}\n Allowed types:\ndeposit individual\ndeposit company\n" +
           "loan individual\nloan company\nmortgage individual\nmortgage company", accountType);

            }

            return output;
        }

        static CustomerType GetCustomerType(string customerType)
        {
            
            if (String.Equals(customerType.ToLowerInvariant(), "individual"))
            {
                CustomerType custType = CustomerType.Individual;
                return custType;
            }
            else
            {
                CustomerType custType = CustomerType.Company;
                return custType;
            }
        }

        static string GetDepositRate(string customerName, string customerType, decimal balance,
            decimal interestRate, uint months)
        {
            CustomerType custType = GetCustomerType(customerType);
            Customer customer = new Customer(custType, customerName);
            Deposit deposit = new Deposit(customer, balance, interestRate);
            decimal rate = deposit.CalculateMonthlyInterest(months);
            return string.Format("{0:F2}", rate) + Environment.NewLine;
        }

        static string GetIndividualLoanRate(string customerName, string customerType, decimal balance,
            decimal interestRate, uint months)
        {
            CustomerType custType = GetCustomerType(customerType);
            Customer customer = new Customer(custType, customerName);
            Loan loan = new Loan(customer, balance, interestRate);
            decimal rate = loan.CalculateMonthlyInterest(months);
            return string.Format("{0:F2}", rate) + Environment.NewLine;
        }

        static string GetCompanyLoanRate(string customerName, string customerType, decimal balance,
            decimal interestRate, uint months)
        {
            CustomerType custType = GetCustomerType(customerType);
            Customer customer = new Customer(custType, customerName);
            Loan loan = new Loan(customer, balance, interestRate);
            decimal rate = loan.CalculateMonthlyInterest(months);
            return string.Format("{0:F2}", rate) + Environment.NewLine;
        }

        static string GetIndividualMortgageRate(string customerName, string customerType, decimal balance,
            decimal interestRate, uint months)
        {
            CustomerType custType = GetCustomerType(customerType);
            Customer customer = new Customer(custType, customerName);
            Mortgage mortgage = new Mortgage(customer, balance, interestRate);
            decimal rate = mortgage.CalculateMonthlyInterest(months);
            return string.Format("{0:F2}", rate) + Environment.NewLine;
        }

        static string GetCompanyMortgageRate(string customerName, string customerType, decimal balance,
            decimal interestRate, uint months)
        {
            CustomerType custType = GetCustomerType(customerType);
            Customer customer = new Customer(custType, customerName);
            Mortgage mortgage = new Mortgage(customer, balance, interestRate);
            decimal rate = mortgage.CalculateMonthlyInterest(months);
            return string.Format("{0:F2}", rate) + Environment.NewLine;
        }

    }
}
