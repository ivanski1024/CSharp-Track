using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumOfKElements
{
    class MaxSumOfKElements
    {
        static void Main()
        {
            Console.WriteLine("Enter the array on a single line seperated with ' '");
            string line = Console.ReadLine();
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            string[] arrStr = line.Split(' ');
            int[] arr = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }
            Array.Sort(arr);
            int Sum = 0;
            for (int i = arr.Length-k; i < arr.Length; i++)
            {
                Sum+=arr[i];
                if (i != arr.Length - k)
                {
                    Console.Write("+");
                }
                Console.Write("{0}", arr[i]);
            }
            Console.WriteLine("={0}", Sum);
        }
    }
}
