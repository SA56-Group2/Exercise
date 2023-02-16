using System;
using System.Collections.Generic;

namespace Class
{
    class Program
    {
        public static void Main()
        {
         Console.WriteLine("--------Create account-------");
         Account myaccount = new Account("S0000111","S1111111A",2000);
         Console.WriteLine($"Your acctNumber is {myaccount.AccNumber},HoldID number is {myaccount.AcctHolderId},balance is {myaccount.Balance}");

         Console.WriteLine("--------Deposit-------");
         myaccount.Deposit(200);
         Console.WriteLine($"Your acctNumber is {myaccount.AccNumber},HoldID number is {myaccount.AcctHolderId},balance is {myaccount.Balance}");

         Console.WriteLine("--------Withdraw-------");
         myaccount.Withdraw(400);
         Console.WriteLine(
          $"Your acctNumber is {myaccount.AccNumber},HoldID number is {myaccount.AcctHolderId},balance is {myaccount.Balance}");

         Console.WriteLine("--------Withdraw-------");
         myaccount.Withdraw(4000);
         Console.WriteLine(
          $"Your acctNumber is {myaccount.AccNumber},HoldID number is {myaccount.AcctHolderId},balance is {myaccount.Balance}");
        }
    }
    public class Account
    {
        private string acctNumber;
        private string acctHolderId;
        private double balance;

        public string AccNumber
        {
         get { return acctNumber;}
        }

        public string AcctHolderId
        {
         get { return acctHolderId; }
         set { acctHolderId = value; }
        }

        public double Balance
        {
         get { return balance; }
         set { balance = value; }
        }

        public Account()
        {
         acctNumber = "S0000111";
         acctHolderId = "S1111111A";
         balance = 2000;
        }
        
        public Account(string acctNumber, string acctHolderId, double balance)
        {
         this.acctNumber = acctNumber;
         this.acctHolderId = acctHolderId;
         this.balance = balance;
        }

        public double Deposit(double money)
        {
         balance += money;
         Console.WriteLine("Operation Succeed!");
         return balance;
        }

        public double Withdraw(double money)
        {
         double initialNum = balance;
         balance -= money;
         double balancefinal = 0;
         if (balance <= 0)
         {
          Console.WriteLine("Sorry, please make sure your account.");
          Balance = initialNum;
         }
         else
         {
          balancefinal = balance;
          Console.WriteLine("Operation succeed! Your balance: {0}", balancefinal);
         }
         return balancefinal;
        }

        public double Transfer(double money, string acctNumber)
        {
         double initialNum = balance;
         balance -= money;
         double balancefinal = 0;
         if (balance <= 0)
         {
          Console.WriteLine("Sorry, please make sure your account.");
          Balance = initialNum;
         }
         else
         {
          balancefinal = balance;
          Console.WriteLine("Operation succeed! Your balance: {0}", balancefinal);
         }
         return balancefinal;
        }
    }
}



    
