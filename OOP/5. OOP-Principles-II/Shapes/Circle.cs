using System;
using System.Linq;

namespace Shapes
{
    class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, radius)
        { }
        public override double CalculateSurface()
        {
            return Math.PI * this.width * this.width;
        }
    }
}
