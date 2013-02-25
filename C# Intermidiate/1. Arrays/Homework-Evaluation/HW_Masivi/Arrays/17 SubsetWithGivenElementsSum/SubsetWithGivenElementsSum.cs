using System;
using System.Collections.Generic;

class SubsetWithGivenElementsSum
{
    static void Main(string[] args)
    {
        int arrLength, sum, subsetLength;
        Console.Write("Enter the length of the array: ");
        arrLength = int.Parse(Console.ReadLine());
        Console.Write("Enter the legth of the subset: ");
        subsetLength = int.Parse(Console.ReadLine());
        Console.Write("Enter the subset sum: ");
        sum = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLength];

        for (int i = 0; i < arrLength; i++) // console entry of the elements of the array
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int sum = 10;
        //int subsetLength = 3;

        List<List<int>> subsetsWithGivenSum = new List<List<int>>();

        for (int i = 0; i < (1 << arr.Length); i++) // get the binary representation of all possible subsets
        {
            List<int> temp = new List<int>();
            int currentSum = 0;

            for (int j = 0; j < arr.Length; j++) // get the current subset
            {
                if (((1 << j) & i) != 0)
                {
                    temp.Add(arr[j]);
                }
            }

            if (temp.Count != subsetLength) // skip all subsets but the ones with the appropriate length
            {
                continue;
            }

            foreach (var element in temp) // get the sum of the current subset
            {
                currentSum += element;
            }

            if (currentSum == sum) // if the subset is compliant save it to the List of int Lists
            {
                subsetsWithGivenSum.Add(temp);
            }
        }

        Console.WriteLine("Subsets in the array with a sum of " + sum);

        foreach (var subset in subsetsWithGivenSum)
        {
            foreach (var number in subset)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine("");
        }
    }
}

