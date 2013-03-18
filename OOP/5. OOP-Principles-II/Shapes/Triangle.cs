﻿using System;
using System.Linq;

namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height) { }

        public override double CalculateSurface()
        {
            return this.width * this.height / 2;
        }
    }
}
