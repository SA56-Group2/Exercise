using System;
using System.Collections.Generic;

namespace Class
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            // Test 1
            Console.WriteLine("----Test 1 test----");
            Account myacconut = new Account("S0000111","S1111111A",2000);
            Account anotherAcc = new Account("S0000333","S3333333B",3500);
            myacconut.ToString();
            anotherAcc.ToString();
            
            Console.WriteLine("----Deposit----");
            myacconut.Deposit(200);
            myacconut.ToString();
            Console.WriteLine("----WithDraw----");
            myacconut.Withdraw(200);
            myacconut.ToString();
            myacconut.Withdraw(4000);
            myacconut.ToString();
            Console.WriteLine("----Transfer----");
            myacconut.Transfer(1000,anotherAcc);
            myacconut.ToString();
            anotherAcc.ToString();
            Console.WriteLine();
            
            // Test 2
            Console.WriteLine("----Test 2 for CurrentAccount test----");
            CurrentAccount currentAccount = new CurrentAccount("S0000333", "S3333333B", 2000);
            currentAccount.ToString();
            Console.WriteLine("----Calaulate the interest----");
            Console.WriteLine("Interest: {0:C}", currentAccount.CalculateInterest());
            Console.WriteLine("----Deposit----");
            currentAccount.CreditInterest();
            currentAccount.ToString();
            Console.WriteLine("----WithDraw----");
            bool canWithraw = currentAccount.Withdraw(3000);
            if (canWithraw)
            {
               Console.WriteLine("Withraw 3000 ok");
            }
            else
            {
               Console.WriteLine("Withraw 3000 fails");
            }
            Console.WriteLine();
            
            // Test 3
            Console.WriteLine("----Test 3 for SavingAccount test----");
            SavingAccount savingAccount = new SavingAccount("S0000111", "S1111111A", 2000);
            savingAccount.ToString();
            Console.WriteLine("----Calaulate the interest----");
            Console.WriteLine("Interest: {0:C}", savingAccount.CalculateInterest());
            Console.WriteLine("----Deposit----");
            savingAccount.CreditInterest();
            savingAccount.ToString();
            Console.WriteLine("----WithDraw----");
            bool canWithraw1 = savingAccount.Withdraw(3000);
            if (canWithraw1)
            {
                Console.WriteLine("Withraw 3000 ok");
            }
            else
            {
                Console.WriteLine("Withraw 3000 fails");
            }
            Console.WriteLine();
            
            // Test 4
            Console.WriteLine("----Test 4 for OverdraftAccount(+) test----");
            OverdraftAccount overdraftAccount = new OverdraftAccount("S0000222", "S2222222C", 2000);
            overdraftAccount.ToString();
            Console.WriteLine("----Calaulate the interest----");
            Console.WriteLine("Interest: {0:C}", overdraftAccount.CalculateInterest());
            Console.WriteLine("----Deposit----");
            overdraftAccount.CreditInterest();
            overdraftAccount.ToString();
            Console.WriteLine();
            
            // Test 5
            Console.WriteLine("----Test 5 for OverdraftAccount(-) test----");
            OverdraftAccount overdraftAccount1 = new OverdraftAccount("S0000222", "S2222222C", -2000);
            overdraftAccount1.ToString();
            Console.WriteLine("----Calaulate the interest----");
            Console.WriteLine("Interest: {0:C}", overdraftAccount1.CalculateInterest());
            Console.WriteLine("----Deposit----");
            overdraftAccount1.CreditInterest();
            overdraftAccount1.ToString();
            Console.WriteLine();
            
            // Test 6
            Console.WriteLine("----Test 6 for Polymorphism test----");
            BankBranch bankBranch = new BankBranch();
            Account myaccount2 = new CurrentAccount("S0000111", "S3333333B", 350.32);
            Account myaccount3 = new CurrentAccount("S0000111", "S1111111B", 4000);
            Account myaccount4 = new SavingAccount("S0000222", "S1111113A", 200);
            Account myaccount5 = new OverdraftAccount("S0000222", "S1111113C", 1500.02);
            Account myaccount6 = new SavingAccount("S0000333", "S1111112A", 4020.23);
            Account myaccount7 = new CurrentAccount("S0000333", "S1111112B", 300);
            Account myaccount8 = new OverdraftAccount("S0000111", "S2222222C", -15000);
            Account myaccount9 = new SavingAccount("S0000333", "S1111113A", 406.31);
            Account myaccount10 = new CurrentAccount("S0000333", "S1111111B", 320.12);
            Account myaccount11 = new OverdraftAccount("S0000111", "S1111113C", -0.94);
            Account myaccount12 = overdraftAccount;
            Account myaccount13 = overdraftAccount1;
            Account myaccount14 = savingAccount;
            Account myaccount15 = currentAccount;
            
            bankBranch.AddAccount(myaccount2);
            bankBranch.AddAccount(myaccount3);
            bankBranch.AddAccount(myaccount4);
            bankBranch.AddAccount(myaccount5);
            bankBranch.AddAccount(myaccount6);
            bankBranch.AddAccount(myaccount7);
            bankBranch.AddAccount(myaccount8);
            bankBranch.AddAccount(myaccount9);
            bankBranch.AddAccount(myaccount10);
            bankBranch.AddAccount(myaccount11);
            bankBranch.AddAccount(myaccount12);
            bankBranch.AddAccount(myaccount13);
            bankBranch.AddAccount(myaccount14);
            bankBranch.AddAccount(myaccount15);

            bankBranch.PrintCustomers();
            Console.WriteLine("---- Deposit ----");
            bankBranch.TotalDeposit();
            Console.WriteLine("---- Interest earned ----");
            bankBranch.totalInterestEarn();
            Console.WriteLine("---- Interest paid ----");
            bankBranch.totalInterestPaid();
            Console.WriteLine("---- Print all the accounts ----");
            bankBranch.PrintAccounts();

        }
    }
}



    