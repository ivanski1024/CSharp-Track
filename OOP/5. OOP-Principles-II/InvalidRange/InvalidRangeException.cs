using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRange
{
    public class InvalidRangeException<T> : System.Exception
    {
        private readonly T  rangeStart, rangeEnd;
        public InvalidRangeException(T rangeStart, T rangeEnd)
            : base()
        {
            this.rangeStart = rangeStart;
            this.rangeEnd = rangeEnd;
        }
        public InvalidRangeException(T rangeStart, T rangeEnd, string message)
            : base(message)
        {
            this.rangeStart = rangeStart;
            this.rangeEnd = rangeEnd;
        }
        public InvalidRangeException(T rangeStart, T rangeEnd, string message, Exception innerException)
            : base(message, innerException)
        {
            this.rangeStart = rangeStart;
            this.rangeEnd = rangeEnd;
        }
        public InvalidRangeException(T rangeStart, T rangeEnd,
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.rangeStart = rangeStart;
            this.rangeEnd = rangeEnd;
        }

    }
}
