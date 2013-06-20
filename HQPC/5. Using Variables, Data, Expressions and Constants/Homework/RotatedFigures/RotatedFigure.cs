using System;
using System.Linq;

namespace RotatedFigures
{
    class Size
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    }

    class RotatedFigure
    {
        public static Size GetRotatedSize(Size s, double angleOfRotation)
        {
            double sin = Math.Sin(angleOfRotation);
            double cos = Math.Cos(angleOfRotation);

            double newWidth = Math.Abs(cos) * s.Width;
                   newWidth += Math.Abs(sin) * s.Height;

            double newHeight = Math.Abs(sin) * s.Width;
                   newHeight += Math.Abs(cos) * s.Height;

            Size newFigure = new Size(newWidth, newHeight);

            return newFigure;
        }
    }
}
