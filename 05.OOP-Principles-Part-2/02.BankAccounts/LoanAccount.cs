namespace BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customer == Customer.Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
            }
            else if (this.Customer == Customer.Company)
            {
                if (months <= 2)
                {
                    return 0;
                }
            }

            return base.CalculateInterestAmount(months);
        }
    }
}
