using System;
using System.Linq;

namespace Bank
{
    class LoanAccount : Account, ITimeDependable
    {

        private static readonly uint monthsWithoutInterestForIndividuals = 3;
        private static readonly uint monthsWithoutInterestForCompanies = 2;

        public LoanAccount(Customer customer, decimal ballance, decimal interestRate)
            : base(customer, ballance, interestRate)
        { }

        public override decimal CalculateInterest(uint numberOfMonths)
        {
            if (this.Customer is Person)
            {
                return CalculateInterestDependingOnTime(numberOfMonths, LoanAccount.monthsWithoutInterestForIndividuals, 0);
            }
            else if (this.Customer is Company)
            {
                return CalculateInterestDependingOnTime(numberOfMonths, LoanAccount.monthsWithoutInterestForCompanies, 0);
            }
            else
            {
                return base.CalculateInterest(numberOfMonths);
            }
        }
        public decimal CalculateInterestDependingOnTime(uint numberOfMonths, uint specialMonthsCount, decimal specialInterest)
        {
            if (this.activeTime > specialMonthsCount)
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
