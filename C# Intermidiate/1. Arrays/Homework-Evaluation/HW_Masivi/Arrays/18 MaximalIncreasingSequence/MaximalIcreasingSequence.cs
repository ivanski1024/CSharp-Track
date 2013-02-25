using System;
using System.Collections.Generic;

class MaximalIcreasingSequence
{
    static void Main(string[] args)
    {
        int arrLength, sum;
        Console.Write("Enter the length of the array: ");
        arrLength = int.Parse(Console.ReadLine());
        Console.Write("Enter the subset sum: ");
        sum = int.Parse(Console.ReadLine());
        int[] arr = new int[arrLength];
        for (int i = 0; i < arrLength; i++) // console entry of the elements of the array
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        //int[] arr = { 11, 21, 13, 14, 4, 5, 6, 17, 18, 82, 19, 10, 30 };

        List<List<int>> increasingSubsets = new List<List<int>>();

        for (int i = 0; i < (1 << arr.Length); i++) // get the binary representation of all possible subsets
        {
            List<int> temp = new List<int>();
            bool sorted = true;

            for (int j = 0; j < arr.Length; j++) // get the current subset
            {
                if (((1 << j) & i) != 0)
                {
                    temp.Add(arr[j]);
                }
            }

            if (temp.Count > 1)
            {
                for (int j = 1; j < temp.Count; j++)
                {
                    if (temp[j-1] > temp[j])
                    {
                        sorted = false;
                    }
                }
            }

            if (sorted) // if the subset is compliant save it to the List of int Lists
            {
                increasingSubsets.Add(temp);
            }
        }

        int maximumSubsetLength = 0;
        int maximumSubsetIndex = 0;

        for (int i = 0; i < increasingSubsets.Count; i++)
        {
            if (increasingSubsets[i].Count > maximumSubsetLength)
            {
                maximumSubsetLength = increasingSubsets[i].Count;
                maximumSubsetIndex = i;
            }
        }

        Console.WriteLine("The maximal sorted subset in the array is");

        foreach (var number in increasingSubsets[maximumSubsetIndex])
        {
            Console.Write(number + " ");
        }
    }
}