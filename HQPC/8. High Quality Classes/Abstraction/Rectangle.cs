namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle()
            : base()
        {
        }

        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.PropertyNotNegativeChecker("Width", value);
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.PropertyNotNegativeChecker("Height", value);
                this.height = value;
            }
        }

        public override double CalcPerimeter()
        {
            return 2 * (this.Width + this.Height);
        }

        public override double CalcSurface()
        {
            return this.Width * this.Height;
        }

        public override string ToString()
        {
            return string.Format(
                "I am a rectangle. My perimeter is {0:f2}. My surface is {1:f2}.",
                this.CalcPerimeter(),
                this.CalcSurface());
        }
    }
}
