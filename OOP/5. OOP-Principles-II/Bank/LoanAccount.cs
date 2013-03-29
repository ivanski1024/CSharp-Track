using System;
using System.Linq;

namespace Bank
{
    class LoanAccount : Account, ITimeDependable
    {

        private static readonly uint individualSpecialMonthsCount = 3;
        private readonly decimal individualSpecialInterestRate = 0;

        private static readonly uint companiesSpecialMonthsCount = 2;
        private readonly decimal companySpecialInterestRate = 0;

        public LoanAccount(Customer customer, decimal ballance, decimal interestRate)
            : base(customer, ballance, interestRate)
        { }

        public override decimal CalculateInterest(uint numberOfMonths)
        {
            if (this.Customer is Person)
            {
                return CalculateInterestDependingOnTime(numberOfMonths, LoanAccount.individualSpecialMonthsCount, this.individualSpecialInterestRate);
            }
            else if (this.Customer is Company)
            {
                return CalculateInterestDependingOnTime(numberOfMonths, LoanAccount.companiesSpecialMonthsCount, this.companySpecialInterestRate);
            }
            else
            {
                return base.CalculateInterest(numberOfMonths);
            }
        }


        public decimal CalculateInterestDependingOnTime(uint numberOfMonths, uint specialMonthsCount, decimal specialInterest)
        {
            decimal newInterest = specialInterest * this.InterestRate;
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
