namespace Class
{
    public class SavingAccount : Account
    {
        private double interestRate = 0.01;

        public double GetInterestRate
        {
            get { return interestRate;}
            set { interestRate = value; }
        }

        public SavingAccount() : base()
        {
            interestRate = 0.01;
        }

        public SavingAccount(string acctnumber, string acctholdId, double balance1) : base(
            acctnumber,acctholdId, balance1)
        {
        }

        public double CalculateInterest()
        {
            double interest = interestRate * GetBalance;
            return interest;
        }

        public void CreditInterest()
        {
            double interest = CalculateInterest();
            base.Deposit(interest);
        }
        
        public bool Withdraw(double amt)
        {
            GetBalance -= amt;
            bool result = GetBalance < 0 ? false : true;
            return result;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}