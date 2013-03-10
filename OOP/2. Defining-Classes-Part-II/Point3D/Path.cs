using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Path
    {
        private List<Point3D> path = new List<Point3D>();

        public Path(List<Point3D> path)
        {
            this.path = path;
        }

        public Point3D this[int i]
        {
            get 
            {
                return path[i];
            }
        }

        public int Count()
        {
            return path.Count;
        }

        /*
        public List<Point3D> GetPath
        {
        }

        */
        public string ToString()
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < path.Count; i++)
            {
                if (i != 0)
                {
                    output.Append(" => ");
                }
                output.AppendFormat("[{0}, {1}, {2}]", path[i].X, path[i].Y, path[i].Z);
            }
            return output.ToString();
        }
    }
}
