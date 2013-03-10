using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortWithMethods
{
    class SelectionSortWithMethods
    {
        static void Main()
        {
            int sortOrder=0;
            int[] arr = GetInput(ref sortOrder);
            SortArray(ref arr, sortOrder);
            Console.WriteLine("The sorted array is:");
            PrintArray(arr);
        }

        private static void SortArray(ref int[] arr, int sortOrder)
        {
            int index;
            int indexOfMax;
            if (sortOrder == -1) // Sorting in descending order
            {

                index = 0;;
                while (index < arr.Length)
                {
                    indexOfMax = GetIndexOfMax(arr, index, arr.Length - 1);
                    if (index != indexOfMax)
                    {
                        SwapElements(ref arr, index, indexOfMax);
                    }
                    index++;
                }
            }
            else    // Sorting in ascending order
            {
                index = arr.Length-1;
                while (index > 0)
                {
                    indexOfMax = GetIndexOfMax(arr, 0, index);
                    if (index != indexOfMax)
                    {
                        SwapElements(ref arr, index, indexOfMax);
                    }
                    index--;
                }
            }
        }

        private static void SwapElements(ref int[] arr, int a, int b) //Swaps elements with indexes a and b in the array arr
        {
            arr[a] += arr[b];
            arr[b] = arr[a] - arr[b];
            arr[a] = arr[a] - arr[b];
        }

        private static int GetIndexOfMax(int[] arr, int index, int p) //Get's the index of the biggest number in given period of an array
        {
            int max = arr[index], maxIndex = index;
            for (int i = index + 1; i <= p; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        static void PrintArray(int[] arr) // Prints an array
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }

        static int[] GetInput(ref int sortOrder) // Reads the program input from the console
        {
            int[] arr = GetArray();
            sortOrder = GetSortOrder();
            return arr;

        }

        static int[] GetArray() // Reads the array
        {
            Console.WriteLine("Enter the array with each element seperated with ' '.");
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            int[] arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }
            return arr;
        }

        static int GetSortOrder() // Reads 1 or -1 for ascending or descending order
        {

            Console.WriteLine("In which order do you want the array to be sorted? ( 1 - Ascending, -1 - Descending)");
            int sortOrder;
            do
            {
                sortOrder = int.Parse(Console.ReadLine());
            }
            while (!(sortOrder == 1 || sortOrder == -1));
            return sortOrder;
        }
    }
}
