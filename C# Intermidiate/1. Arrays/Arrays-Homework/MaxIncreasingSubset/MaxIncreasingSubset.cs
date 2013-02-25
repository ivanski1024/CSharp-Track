using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxIncreasingSubset
{
    class MaxIncreasingSubset
    {
        static void Main()
        {
            Console.WriteLine("Enter the array on a single line seperated with ' '");
            string line = Console.ReadLine();
            string[] arrStr = line.Split(' ');
            int l = arrStr.Length;
            int[] arr = new int[l];
            int pow = 1;
            for (int i = 0; i < l; i++)
            {
                pow *= 2;
                arr[i] = int.Parse(arrStr[i]);
            }
            int currLength, lastNumber = 0, maxLength = 0, maxN = 0;
            bool firstOne = true, firstIncreasing = true;
            for (int i = 1; i < pow; i++)
            {
                currLength = 0;
                firstOne = true;
                for (int j = 0; j < l; j++)
                {
                    if (((i & (1 << j)) >> j) == 1)
                    {
                        if (firstOne)
                        {
                            lastNumber = arr[j];
                            firstOne = false;
                            currLength++;
                        }
                        else
                        {
                            if (arr[j] <= lastNumber)
                            {
                                break;
                            }
                            else
                            {
                                lastNumber = arr[j];
                                currLength++;
                            }
                        }
                    }
                }
                if (firstIncreasing)
                {
                    maxLength = currLength;
                    maxN = i;
                    firstIncreasing = false;
                }
                else
                {

                    if (currLength > maxLength)
                    {
                        maxLength = currLength;
                        maxN = i;
                    }
                }
            }
            for (int j = 0; j < l; j++)
            {
                if (((maxN & (1 << j)) >> j) == 1)
                {
                    Console.Write("{0} ", arr[j]);
                }
            }
        }
    }
}
