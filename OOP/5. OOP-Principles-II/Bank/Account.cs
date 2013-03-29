using System;
using System.Linq;

namespace Bank
{
    abstract class Account
    {
        public Customer Customer { get; protected set; }
        public decimal Ballance { get; protected set; }
        public decimal InterestRate { get; protected set; }

        protected Account(Customer customer, decimal ballance, decimal interestRate)
        {
            this.Customer = customer;
            this.Ballance = ballance;
            this.InterestRate = interestRate;
        }

        public virtual decimal CalculateInterest(uint numberOfMonths)
        {
            return this.InterestRate * this.Ballance * numberOfMonths;
        }

        public virtual void Deposit(decimal amount)
        {
            this.Ballance += amount;
        }
    }
}
