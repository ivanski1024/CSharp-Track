using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInarySearch
{
    class BInarySearch
    {
        static void Main()
        {
            Console.WriteLine("Enter an sorted array with elements seperated by ' ':");
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            int[] array = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                array[i] = int.Parse(nums[i]);
            }
            Console.Write("Enter the element you search for: ");
            int element = int.Parse(Console.ReadLine());
            int result = BinarySearchFunc(array, 0, array.Length - 1, element);
            if (result == -1)
            {
                Console.WriteLine("The element {0} doesn't occur in the given array.", element);
            }
            else
            {
                Console.WriteLine("The element {0} is with index {1} in the given array.", element, result);
            }
        }
        static int BinarySearchFunc(int[] array, int left, int right, int element)
        {
            if (left == right)
            {
                if (array[left] == element)
                {
                    return left;
                }
                else
                {
                    return -1;
                }
            }
            else 
            {
                int center = (right - left) / 2 + left;
                if (array[center] == element)
                {
                    return center;
                }
                else if (array[center] > element)
                {
                    return BinarySearchFunc(array, left, center - 1, element);
                }
                else if (array[center] < element)
                {
                    return BinarySearchFunc(array, center + 1, right, element);
                }
            }
            return 0;
        }
    }
}
