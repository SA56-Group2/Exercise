namespace Class
{
    public class CurrentAccount : Account
    {
        private double interestRate = 0.025;

        public double GetInterestRate
        {
            get { return interestRate;}
            set { interestRate = value; }
        }

        public CurrentAccount() : base()
        {
            interestRate = 0.0025;
        }

        public CurrentAccount(string acctnumber, string acctholdId, double balance1) : base(
            acctnumber,acctholdId, balance1)
        {
        }

        public override double CalculateInterest()
        {
            return base.CalculateInterest()*interestRate;
        }

        public override void CreditInterest()
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