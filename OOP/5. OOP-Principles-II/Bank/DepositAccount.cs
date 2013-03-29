using System;
using System.Linq;

namespace Bank
{
    class DepositAccount : Account
    {
        private static readonly uint minimumSumForInterest = 1000;

        public DepositAccount(Customer customer, decimal ballance, decimal interestRate)
            : base(customer, ballance, interestRate)
        { }

        public override decimal CalculateInterest(uint numberOfMonths)
        {
            if (this.Ballance > 0 && this.Ballance < DepositAccount.minimumSumForInterest)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(numberOfMonths);
            }
        }
        public void Withdraw(decimal amount)
        {
            this.Ballance -= amount;
        }
    }
}
