namespace Abstraction
{
    using System;

    public abstract class Figure
    {
        public Figure()
        {
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        protected void PropertyNotNegativeChecker(string propertyName, double propertyValue)
        {
            if (propertyValue < 0)
            {
                throw new ArgumentException(string.Format("{0} shouldn't be negative!"));
            }
        }
    }
}
