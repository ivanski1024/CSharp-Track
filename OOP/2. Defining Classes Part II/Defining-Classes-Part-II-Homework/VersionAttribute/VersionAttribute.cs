using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [VersionAttribute(1.0)]
    class AttributeDemo
    {
        static void Main(string[] args)
        {
            Type myType = typeof(AttributeDemo);
            object[] allAttributes =
                myType.GetCustomAttributes(false);
            foreach (VersionAttribute version in allAttributes)
            {
                Console.WriteLine("Version: {0:F}", version.Version);
            }
        }
    }
}

