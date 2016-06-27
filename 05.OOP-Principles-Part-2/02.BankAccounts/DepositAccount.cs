namespace BankAccounts
{
    using System;

    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) 
        {
        }

        public void Withdraw(decimal amountOfMoney)
        {
            if (this.Balance < amountOfMoney)
            {
                throw new ArgumentException("Invalid withdraw sum! Current balance is smaller!");
            }

            this.Balance -= amountOfMoney;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Balance >= 0 && this.Balance < 1000m)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestAmount(months);
            }
        }
    }
}
