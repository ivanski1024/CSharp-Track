using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
    class Bank
    {
        static private List<Account> accounts = new List<Account>();
        static void Main()
        {
            accounts.Add(new DepositAccount(new Person("Svetlin Nakov"), 10000, 0.06m));
            accounts.Add(new LoanAccount(new Person("Georgi Georgiev"), -5000, 0.10m));
            accounts.Add(new MortgageAccount(new Company("Telerik"), -1000000, 0.15m));
            foreach (Account acc in accounts)
            {
                Console.WriteLine(acc.CalculateInterest(24));
            }
        }
    }
}
