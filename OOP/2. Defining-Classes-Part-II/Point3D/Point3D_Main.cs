using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Point3D
{
    class Point3D_Main 
    {
        static void Main()
        {
            
            Console.WriteLine(Distance.CalculateDistance(Point3D.O, new Point3D("A", 0, 3, 4)));

            PathStorage.SavePath(PathStorage.LoadPath(new StreamReader("../../path.txt")), new StreamWriter("../../pathCopy.txt"));

            //Console.WriteLine( PathStorage.LoadPath( new StreamReader("../../path.txt")).ToString());

            List<int> list = new List<int>();
            Console.WriteLine(list.Min<int>().ToString());
            
            //Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            /*
            var ci = CultureInfo.InvariantCulture.Clone() as CultureInfo;
            ci.NumberFormat.NumberDecimalSeparator = ".";
            
            string a="1.3";
            Console.WriteLine(  double.Parse(a, ci) );

            */
        }
    }
}
