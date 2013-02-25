using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexTimesFive
{
    class IndexTimesFive
    {
        static void Main()
        {
            int[] Arr = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Arr[i] = i * 5;
                Console.WriteLine("Arr[{0}] = {1}", i, Arr[i]);
            }
        }
    }
}
