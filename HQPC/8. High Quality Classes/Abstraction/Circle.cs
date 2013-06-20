﻿namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        private double radius;

        public Circle()
            : base()
        {
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                this.PropertyNotNegativeChecker("Radius", value);
                this.radius = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        public override string ToString()
        {
            return string.Format(
                "I am a circle. My perimeter is {0:f2}. My surface is {1:f2}.",
                this.CalcPerimeter(),
                this.CalcSurface());
        }
    }
}
