using System.Text;
namespace Point3D
{
    struct Point3D
    {
        private static Point3D o = new Point3D("O", 0, 0, 0);
        private string name;
        private double x, y, z;

        public double X
        {
            get 
            {
                return x;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
        }
        public double Z
        {
            get
            {
                return z;
            }
        }

        public static Point3D O
        {
            get
            {
                return o;
            }
        }

        public Point3D(double x, double y, double z)
        {
            this.name = null;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3D(string name, double x, double y, double z)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0} { {1}, {2}, {3} }", name, x, y, z);
            return output.ToString();
        }
    }
}
