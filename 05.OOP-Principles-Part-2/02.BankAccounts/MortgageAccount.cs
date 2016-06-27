namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Customer == Customer.Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }

                return base.CalculateInterestAmount(months);
            }
            else // Company
            {
                if (months <= 12)
                {
                    return base.CalculateInterestAmount(months) / 2;
                }
                else
                {
                    return (base.CalculateInterestAmount(months) / 2) + (base.CalculateInterestAmount(months - 12) / 2);
                }
            }
        }
    }
}
