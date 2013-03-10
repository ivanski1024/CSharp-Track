using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequance
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            string[] arr = line.Split(' ');
            string maxEl = arr[0];
            int maxL=0, currL=1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currL++;
                }
                else
                {
                    if (currL > maxL)
                    {
                        maxL = currL;
                        maxEl = arr[i - 1];
                    }
                    currL = 1;
                }
            }
            for (int i = 0; i < maxL; i++)
            {
                Console.Write("{0} ", maxEl);
            }
        }
    }
}
