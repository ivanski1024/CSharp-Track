using System;
using System.Linq;

namespace Bank
{
    abstract class Account
    {
        protected Customer customer;
        protected decimal ballance;
        protected decimal interestRate;
        protected int activeTime = 0;

        protected Account(Customer customer, decimal ballance, decimal interestRate)
        {
            this.customer = customer;
            this.ballance = ballance;
            this.interestRate = interestRate;
            this.activeTime = 0;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            protected set 
            {
                this.customer = value;
            }
        }
        public decimal Ballance
        {
            get
            {
                return this.ballance;
            }
            protected set
            {
                this.ballance = value;
            }
        }
        public decimal InterestRate
        {
            get 
            {
                return this.interestRate;
            }
            protected set
            {
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(uint numberOfMonths)
        {
            return this.interestRate * this.Ballance * numberOfMonths;
        }
    }
}
