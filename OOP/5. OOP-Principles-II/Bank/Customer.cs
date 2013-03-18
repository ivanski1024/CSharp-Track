using System;
using System.Linq;

namespace Bank
{
    abstract class Customer
    {

        private readonly string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}