using System;
using System.Collections.Generic;

class MergeSort
{
    static void ArrayCopy(int[] sourceArray, int[] targetArray, int startIndex, int endIndex)
    {
        for (int i = startIndex; i <= endIndex; i++)
        {
            targetArray[i - startIndex] = sourceArray[i];
        }
    }

    static int[] Mergesort(int[] array)
    {
        if (array.Length == 1)
        {
            return array;
        }

        int[] firstArray = new int[array.Length / 2];
        int[] secondArray = new int[array.Length - array.Length / 2];

        ArrayCopy(array, firstArray, 0, array.Length / 2 - 1);
        ArrayCopy(array, secondArray, array.Length / 2, array.Length - 1);

        firstArray = Mergesort(firstArray);
        secondArray = Mergesort(secondArray);

        return Merge(firstArray, secondArray);
    }

    static int[] Merge(int[] array1, int[] array2)
    {
        List<int> protoResult = new List<int>();
        int index = 0;

        List<int> list1 = new List<int>(array1);
        List<int> list2 = new List<int>(array2);

        while ((list1.Count != 0) && (list2.Count != 0))
        {
            if (list1[0] > list2[0])
            {
                protoResult.Add(list2[0]);
                list2.RemoveAt(0);
            }
            else
            {
                protoResult.Add(list1[0]);
                list1.RemoveAt(0);
            }
        }

        while (list1.Count != 0)
        {
            protoResult.Add(list1[0]);
            list1.RemoveAt(0);
        }

        while (list2.Count != 0)
        {
            protoResult.Add(list2[0]);
            list2.RemoveAt(0);        
        }

        return protoResult.ToArray();
    }

    static void Main(string[] args)
    {
        int arrLength;
        Console.Write("Enter the length of the array: ");
        arrLength = int.Parse(Console.ReadLine());
        int[] arr = new int[arrLength];
        for (int i = 0; i < arrLength; i++) // console entry of the elements of the array
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int[] sortedArr = Mergesort(arr);

        Console.WriteLine("\n Sorted Array");

        foreach (var element in sortedArr)
        {
            Console.WriteLine(element);
        }
    }
}