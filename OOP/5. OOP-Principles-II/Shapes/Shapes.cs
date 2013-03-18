using System;
using System.Linq;

namespace Shapes
{
    class Shapes
    {
        static void Main(string[] args)
        {
            Shape[] shapes = 
            {
                new Triangle(2, 2),
                new Rectangle(2, 2),
                new Circle(2)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("This {0} has surface of {1}", shape.GetType(), shape.CalculateSurface());
            }
        }
    }
}
