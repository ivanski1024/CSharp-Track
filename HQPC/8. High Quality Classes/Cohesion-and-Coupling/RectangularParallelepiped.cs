namespace CohesionAndCoupling
{
    using System;
    using System.Linq;

    public class RectangularParallelepiped
    {
        private double width;
        private double height;
        private double depth;

        public RectangularParallelepiped()
        {
        }

        public RectangularParallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value >= 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Width should be not-negative number!");
                }
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
                if (value >= 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Height should be not-negative number!");
                }
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value >= 0)
                {
                    this.depth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Depth should be not-negative number!");
                }
            }
        }

        public double Volume
        {
            get
            {
                return this.Width * this.Height * this.Depth;
            }
        }

        public double DiagonalXYZ
        {
            get
            {
                return Geometry.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            }
        }

        public double DiagonalXY
        {
            get
            {
                return Geometry.CalcDistance2D(0, 0, this.Width, this.Height);
            }
        }

        public double DiagonalXZ
        {
            get
            {
                return Geometry.CalcDistance2D(0, 0, this.Width, this.Depth);
            }
        }

        public double DiagonalYZ
        {
            get
            {
                return Geometry.CalcDistance2D(0, 0, this.Height, this.Depth);
            }
        }
    }
}
