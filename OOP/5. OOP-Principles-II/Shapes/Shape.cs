using System;
using System.Linq;

namespace Shapes
{
    abstract class Shape
    {
        protected double width, height;
        protected Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public abstract double CalculateSurface();
    }
}
