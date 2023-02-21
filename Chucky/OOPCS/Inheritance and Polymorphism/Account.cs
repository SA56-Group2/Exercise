using System;

namespace Class
{
    public class Account
    {
        private string acctNumnber;
        private string acctHoldId;
        private double balance;
        
        public string GetAcctNumber
        {
            get { return acctNumnber; }
        }

        public string GetAcctHolderId
        {
            get { return acctHoldId; }
            set { acctHoldId = value; }
        }
        public double GetBalance
        {
            get { return balance; }
            set { balance = value; }
        }
        
        // Constructors
        public Account()
        {
            acctNumnber = "S0000111";
            acctHoldId = "S1111111A";
            balance = 2000;
        }
        public Account(string acctnumnber, string acctholdId, double balance1)
        {
            this.acctNumnber = acctnumnber;
            this.acctHoldId = acctholdId;
            this.balance = balance1;
        }
        
        //Method
        public void Deposit(double amt)
        {
            balance += amt;
            Console.WriteLine("Operation Succees!");
        }

        public void Withdraw(double amt)
        {
            double oribalance = balance;
            balance -= amt;
            if (balance < 0)
            {
                Console.WriteLine("Sorry,operation failed. Please make your balance.");
                balance = oribalance;
            }
            else
            {
                Console.WriteLine("Operation Success!");
            }
        }
        
        public void Transfer(double amt, Account another)
        {
            double oribalance = balance;
            balance -= amt;
            if (balance < 0)
            {
                Console.WriteLine("Sorry,operation failed. Please make your balance.");
                balance = oribalance;
            }
            else
            {
                Console.WriteLine("Operation Success!");
                another.balance += this.balance;
            }
        }

        public override string ToString()
        {
            Console.WriteLine($"Account: Your Number is {acctNumnber}, your ID is {acctHoldId}, your balance is {balance:C}");
            return base.ToString();
        }

        public virtual double CalculateInterest()
        {
            return balance;
        }

        public virtual void CreditInterest()
        {
            double interest = CalculateInterest();
            this.Deposit(interest);
        }


    }
}
