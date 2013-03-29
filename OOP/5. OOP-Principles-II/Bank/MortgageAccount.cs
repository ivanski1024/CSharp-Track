using System;
using System.Linq;

namespace Bank
{
    class MortgageAccount : Account, ITimeDependable
    {
        public MortgageAccount(Customer customer, decimal ballance, decimal interestRate)
            : base(customer, ballance, interestRate)
        { }


        private static readonly uint individualSpecialMonthsCount = 6;
        private readonly decimal individualSpecialInterestRate = 0;

        private static readonly uint companiesSpecialMonthsCount = 12;
        private readonly decimal companySpecialInterestRate = 0.5m;

        public override decimal CalculateInterest(uint numberOfMonths)
        {
            if (this.Customer is Person)
            {
                return CalculateInterestDependingOnTime(numberOfMonths, individualSpecialMonthsCount, individualSpecialInterestRate);
            }
            else if (this.Customer is Company)
            {
                return CalculateInterestDependingOnTime(numberOfMonths, companiesSpecialMonthsCount, companySpecialInterestRate);
            }
            else
            {
                return base.CalculateInterest(numberOfMonths);
            }
        }
        public decimal CalculateInterestDependingOnTime(uint numberOfMonths, uint specialMonthsCount, decimal specialInterest)
        {
            decimal newInterest = this.InterestRate * specialInterest;

            if (numberOfMonths < specialMonthsCount)
            {
                return numberOfMonths * newInterest * this.Ballance;
            }
            else
            {
                return base.CalculateInterest(numberOfMonths - specialMonthsCount) + specialMonthsCount * newInterest * this.Ballance;
            }
        }
    }
}
