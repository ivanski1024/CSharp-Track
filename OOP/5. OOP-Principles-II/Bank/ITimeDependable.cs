using System;
using System.Linq;

namespace Bank
{
    interface ITimeDependable //Accounts that depend on the time passed from the opening of the account. Their interest for given period of time is calculated in special way.
    {
        decimal CalculateInterestDependingOnTime(uint numberOfMonths, uint specialMonthsCount, decimal specialInterest);
    }
}
