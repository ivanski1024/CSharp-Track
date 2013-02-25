using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsequanceWithMaxSum
{
    class SubsequanceWithMaxSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            string Line = Console.ReadLine();
            string[] nums = Line.Split(' ');
            for (int i = 0; i < n; i++)
            {
                numbers[i]=int.Parse(nums[i]);
            }
            int max_so_far = numbers[0], max_ending_here = numbers[0];
            int begin = 0;
            int begin_temp = 0;
            int end = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                max_ending_here += numbers[i];
                if (numbers[i] > max_ending_here)
                {
                    max_ending_here = numbers[i];
                    begin_temp = i;
                }
                if (max_ending_here > max_so_far)
                {
                    max_so_far = max_ending_here;
                    begin = begin_temp;
                    end = i;
                }
            }
            for (int i = begin; i <= end; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
