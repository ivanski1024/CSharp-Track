using System;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method )]
    public class VersionAttribute : Attribute
    {
        public double Version {get; set;}
        public VersionAttribute(double version)
        {
            this.Version = version;
        }
    }
}
