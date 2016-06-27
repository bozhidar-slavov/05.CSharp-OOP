namespace BankAccounts
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class Startup
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var deposit = new DepositAccount(customer: Customer.Company, balance: 200, interestRate: 20);

            Console.WriteLine("Deposit account's Interest Amount: {0}", deposit.CalculateInterestAmount(months: 6));

            // when balance is more than 1000
            deposit.Deposit(900m);
            Console.WriteLine("Deposit account's Interest Amount: {0}\n", deposit.CalculateInterestAmount(months: 6));

            // individual
            var loanIndividual = new LoanAccount(customer: Customer.Individual, balance: 100, interestRate: 15);

            Console.WriteLine("Loan individual account's Interest Amount: {0}", loanIndividual.CalculateInterestAmount(months: 3));
            Console.WriteLine("Loan individual account's Interest Amount: {0}\n", loanIndividual.CalculateInterestAmount(months: 5));

            // company
            var loanCompany = new LoanAccount(customer: Customer.Company, balance: 100, interestRate: 15);

            Console.WriteLine("Loan company account's Interest Amount: {0}", loanCompany.CalculateInterestAmount(months: 2));
            Console.WriteLine("Loan company account's Interest Amount: {0}\n", loanCompany.CalculateInterestAmount(months: 5));

            // individual
            var mortIndividual = new MortgageAccount(customer: Customer.Individual, balance: 350, interestRate: 5);

            Console.WriteLine("Mortgage individual account's Interest Amount: {0}", mortIndividual.CalculateInterestAmount(months: 7));
            Console.WriteLine("Mortgage individual account's Interest Amount: {0}\n", mortIndividual.CalculateInterestAmount(months: 8));

            // company
            var mortCompany = new MortgageAccount(customer: Customer.Company, balance: 20000, interestRate: 15);

            Console.WriteLine("Mortgage company account's Interest Amount: {0}", mortCompany.CalculateInterestAmount(months: 10));
            Console.WriteLine("Mortgage company account's Interest Amount: {0}\n", mortCompany.CalculateInterestAmount(months: 24));
        }
    }
}
