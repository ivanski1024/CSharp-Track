using System;
using System.Linq;

namespace Bank
{
    class MortgageAccount : Account, ITimeDependable
    {
        public MortgageAccount(Customer customer, decimal ballance, decimal interestRate)
            : base(customer, ballance, interestRate)
        { }

        public override decimal CalculateInterest(uint numberOfMonths)
        {
            if (this.customer is Person)
            {
                return CalculateInterestDependingOnTime(numberOfMonths, 6, 0);
            }
            else if (this.customer is Company)
            {
                return CalculateInterestDependingOnTime(numberOfMonths, 12, 0.5m);
            }
            else
            {
                return base.CalculateInterest(numberOfMonths);
            }
        }
        public decimal CalculateInterestDependingOnTime(uint numberOfMonths, uint specialMonthsCount, decimal specialInterest)
        {
            if (activeTime > specialMonthsCount)
            {
                return base.CalculateInterest(numberOfMonths);
            }
            else
            {
                if (activeTime + numberOfMonths < specialMonthsCount)
                {
                    return (this.activeTime + numberOfMonths) * specialInterest * this.ballance;
                }
                else
                {
                    return base.CalculateInterest(activeTime + numberOfMonths - specialMonthsCount) + (specialMonthsCount-activeTime)*specialInterest*this.ballance;
                }
            }
            
        }

    }
}
