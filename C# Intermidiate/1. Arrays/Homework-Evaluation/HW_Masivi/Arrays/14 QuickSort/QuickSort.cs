using System;
using System.Collections.Generic;

class QuickSort
{
    static string[] Sort(string[] unsortedArray)
    {
        if (unsortedArray.Length <= 1)
        {
            return unsortedArray;
        }

        string pivot = unsortedArray[0];
        List<string> lesser = new List<string>();
        List<string> greater = new List<string>();
        List<string> result = new List<string>();

        for (int i = 1; i < unsortedArray.Length; i++)
        {
            if (string.Compare(unsortedArray[i], pivot) < 0)
            {
                lesser.Add(unsortedArray[i]);
            }
            else
            {
                greater.Add(unsortedArray[i]);
            }
        }

        result.AddRange(Sort(lesser.ToArray()));
        result.Add(pivot);
        result.AddRange(Sort(greater.ToArray()));

        return result.ToArray();
    }

    static void Main()
    {
        int arrLength;
        Console.Write("Enter the length of the array: ");
        arrLength = int.Parse(Console.ReadLine());
        string[] arr = new string[arrLength];
        for (int i = 0; i < arrLength; i++) // console entry of the elements of the array
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = Console.ReadLine();
        }

        string[] sortedArr = Sort(arr);

        Console.WriteLine("\n Sorted Array");

        foreach (var element in sortedArr)
        {
            Console.WriteLine(element);
        }
    }
}

