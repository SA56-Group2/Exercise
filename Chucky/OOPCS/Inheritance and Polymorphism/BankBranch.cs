using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    public class BankBranch
    {
        List<Account> acctList = new List<Account>();
        
        public void AddAccount(Account account)
        {
           acctList.Add(account);
        }

        public void PrintCustomers()
        {
            List<Account> acctListNew = LoopforRepeat();
            Console.Write("All the account HolderID are: ");
            foreach (var ele in acctListNew)
            {
                Console.Write($"{ele.GetAcctHolderId} ");
            }
            Console.WriteLine();
        }

        public void TotalDeposit()
        {
            List<Account> acctListNew = LoopforRepeat();
            foreach (var ele in acctListNew)
            {
                Console.WriteLine($"{ele.GetAcctHolderId}'s deposit is: {ele.GetBalance:C}");
            }
        }
        
        public void totalInterestEarn()
        {
            List<Account> acctListNew = LoopforRepeat();
            double totalInterest = 0; 
            foreach (var ele in acctListNew)
            {
                string s = ele.GetAcctHolderId.ToString().Substring(8, 1);
                if ((s == "B") || (s == "A"))
                {
                    double interest = ele.GetBalance * 0.0025;
                    totalInterest += interest;
                    ele.GetBalance += totalInterest;
                    Console.WriteLine($"{ele.GetAcctHolderId} will earn {interest:C}.");
                }
                else if ((s == "C") && (ele.GetBalance >= 0))
                {
                    double interest = ele.GetBalance * 0.0025;
                    totalInterest += interest;
                    ele.GetBalance += totalInterest;
                    Console.WriteLine($"{ele.GetAcctHolderId} will earn {interest:C}.");
                }
            }
            Console.WriteLine("The total interest earned is : {0:C}",totalInterest);
        }
        
        public void totalInterestPaid()
        {
            List<Account> acctListNew = LoopforRepeat();
            double totalInterest = 0;
            foreach (var ele in acctListNew)
            {
                string s = ele.GetAcctHolderId.ToString().Substring(8, 1);
                if ((s == "C") && ele.GetBalance<0)
                {
                    double interest = ele.GetBalance * 0.06;
                    totalInterest += interest;
                    ele.GetBalance += totalInterest;
                    Console.WriteLine($"{ele.GetAcctHolderId} will paid {interest:C}.");
                }
            }
            Console.WriteLine("The total interest paid is : {0:C}",totalInterest);
        }

        public void PrintAccounts()
        {
            foreach (var ele in acctList)
            {
                Console.WriteLine($"The {ele.GetAcctHolderId}'s account is (deposit + interest): {ele.GetBalance:C}.");
            }
        }

        public List<Account> LoopforRepeat()
        {
            for (int i = 0; i < acctList.Count-1; i++)
            {
                for (int j = i+1; j < acctList.Count; j++)
                {
                    if (acctList.ElementAt(i).GetAcctHolderId == acctList.ElementAt(j).GetAcctHolderId)
                    {
                        acctList.ElementAt(i).GetBalance += acctList.ElementAt(j).GetBalance;
                        acctList.RemoveAt(j);
                    }
                }
            }
            return acctList;
        }
        
        
    }
}