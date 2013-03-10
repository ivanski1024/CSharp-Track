using System;
namespace Point3D
{
    static class Distance
    {
        public static double CalculateDistance(Point3D pointA, Point3D pointB)
        {
            return System.Math.Sqrt(
                (pointB.X - pointA.X) * (pointB.X - pointA.X) +
                (pointB.Y - pointA.Y) * (pointB.Y - pointA.Y) +
                (pointB.Z - pointA.Z) * (pointB.Z - pointA.Z));
        }
    }

}
