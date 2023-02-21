using System;

namespace Class
{
    public class OverdraftAccount : Account
    {
        private double interestRateP = 0.025;
        private double interestRateN = 0.06;

        public double GetInterestRateP
        {
            get { return interestRateP;}
            set { interestRateP = value; }
        }

        public double GetInterestRateN
        {
            get { return interestRateN;}
            set { interestRateN = value;}
        }

        public OverdraftAccount() : base()
        {
            interestRateP = 0.0025;
            interestRateN = 0.06;
        }

        public OverdraftAccount(string acctnumber, string acctholdId, double balance1) : base(
            acctnumber,acctholdId, balance1)
        {
        }
        
        public override double CalculateInterest()
        {
            double interestRate = GetBalance >= 0 ? interestRateP : interestRateN;
            return base.CalculateInterest()*interestRate;
        }

        public override void CreditInterest()
        {
            double interest = CalculateInterest();
            base.Deposit(interest);
        }
        
        public void Withdraw(double amt)
        {
            GetBalance -= amt;
            Console.WriteLine("Operation Succees!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}