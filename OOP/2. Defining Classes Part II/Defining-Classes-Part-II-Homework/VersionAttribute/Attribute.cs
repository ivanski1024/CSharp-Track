using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method )]
    public class VersionAttribute : Attribute
    {
        private double version;

        public VersionAttribute(double version)
        {
            this.version = version;
        }

        public double Version
        {
            get 
            {
                return this.version;
            }
            set 
            {
                this.version = value;
            }
        }

    }


}
