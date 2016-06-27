namespace BankAccounts
{
    using System;

    public abstract class Account : IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; private set; }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative!");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate cannot be negative");
                }

                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be negative");
            }

            return this.Balance * (this.InterestRate / 100) * months;
        }

        public void Deposit(decimal amountOfMoney)
        {
            if (amountOfMoney <= 0)
            {
                throw new ArgumentException("Invalid amount of money!");
            }

            this.balance += amountOfMoney;
        }
    }
}
