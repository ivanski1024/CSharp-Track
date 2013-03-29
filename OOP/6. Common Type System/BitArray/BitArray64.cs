using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        private ulong array;
        public BitArray64(ulong number)
        {
            this.array = number;
        }
        public BitArray64()
        {
            this.array = 0;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (byte index = 0; index < 64; index++)
            {
                yield return this[index];
            }
        }
        public int this[byte index]
        {
            get
            {
                IndexCheck(index); 
                if ((this.array & (((ulong)1) << index)) == 0)
                    return 0;
                else
                    return 1;
            }
            set
            {
                // Checks the index
                IndexCheck(index);
                if (value == 1 || value == 0)
                {
                    // Clear the bit at position index
                    array &= ~((ulong)(1 << index));
                    // Set the bit at position index to value
                    array |= (ulong)(value << index);
                }
                else
                {
                    throw new ArgumentException("Argument must be 0 or 1");
                }
            }
        }
        private void IndexCheck(int index)
        {
            if( ! (index >= 0 && index < 64))
            {
                throw new IndexOutOfRangeException();
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is BitArray64)
            {
                return (obj as BitArray64).array.Equals(this.array);
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(BitArray64 left, BitArray64 right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(BitArray64 left, BitArray64 right)
        {
            return !(left.Equals(right));
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                output.Append(( (ulong)(1 << i) & this.array) >> i);
            }
            return output.ToString();
        }
    }
}