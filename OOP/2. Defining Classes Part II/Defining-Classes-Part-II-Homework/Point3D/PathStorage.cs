//Format for path in a file:
// -------------------------
// [X1, Y1, Z1]
// [X2, Y2, Z2]
// ............
// [Xn, Yn, Zn]
// -------------------------
// Where Xi, Yi and Zi are real numbers.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Point3D
{
    static class PathStorage
    {
        public static Path LoadPath( StreamReader file )
        {
            using (file)
            {
                List<Point3D> list = new List<Point3D>();
                for(string line = file.ReadLine(); line!=null; line=file.ReadLine())
                {
                    string[] seperators = { " ", "[", ",", "]" };
                    string[] coordinates = line.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                    Point3D point = new Point3D( double.Parse(coordinates[0]), double.Parse(coordinates[1]), double.Parse(coordinates[2]));
                    list.Add(point);
                }
                Path path = new Path(list);
                return path;
            }
        }

        public static void SavePath(Path path, StreamWriter file)
        {
            using (file)
            {
                for (int i = 0; i < path.Count(); i++)
                {
                    file.WriteLine("[{0}, {1}, {2}]", path[i].X, path[i].Y, path[i].Z);
                }
            }
        }
    }
}
