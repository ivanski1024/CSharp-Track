/*
 * 5. Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> 
 * and Equals(…), GetHashCode(), [], == and !=.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class BitArrayMain
    {
        static void Main(string[] args)
        {
            BitArray64 array = new BitArray64(ulong.MaxValue);
            array[8] = 0;
            for (byte i = 0; i < 64; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
