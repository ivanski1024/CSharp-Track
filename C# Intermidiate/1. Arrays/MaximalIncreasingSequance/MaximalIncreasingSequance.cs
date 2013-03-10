using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequance
{
    class MaximalIncreasingSequance
    {
        static void Main()
        {
            string line = Console.ReadLine();
            string[] arrStr = line.Split(' ');
            int[] arr = new int[arrStr.Length];
            int startPos = 0, maxL = 1, currL = 1;
            arr[0] = int.Parse(arrStr[0]);
            for (int i = 1; i < arr.Length; i++)
            {

                arr[i]=int.Parse(arrStr[i]);
                if ( arr[i] > arr[i - 1] )
                {
                    currL++;
                }
                else
                {
                    if (currL > maxL)
                    {
                        maxL = currL;
                        startPos = i - maxL;
                    }
                    currL = 1;
                }
            }
            if (currL > maxL)
            {
                maxL = currL;
                startPos = arr.Length - maxL;
            }
            for (int i = startPos; i < startPos+maxL; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
