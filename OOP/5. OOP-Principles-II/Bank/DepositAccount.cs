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
            if (this.ballance > 0 && this.ballance < DepositAccount.minimumSumForInterest)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(numberOfMonths);
            }
        }
    }
}
