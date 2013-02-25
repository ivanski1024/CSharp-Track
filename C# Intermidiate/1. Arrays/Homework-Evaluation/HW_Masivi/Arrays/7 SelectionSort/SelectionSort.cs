using System;
using System.Collections.Generic;

class SelectionSort
{
    static int FindSmallestArrayElement(int[] array, out int index)
    {
        int smallestElement = array[0];
        index = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < smallestElement)
            {
                smallestElement = array[i];
                index = i;
            }
        }

        return smallestElement;
    }
    static void Main()
    {
        int arrLength;
        Console.Write("Enter the length of the array: ");
        arrLength = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrLength; i++)
        {
            int smallestElement = arr[i], swapVar;
            int index = i;

            for (int j = i; j < arrLength; j++)
            {
                if (arr[j] < smallestElement)
                {
                    smallestElement = arr[j];
                    index = j;
                }               
            }

            swapVar = arr[i];
            arr[i] = arr[index];
            arr[index] = swapVar;
        }

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < arrLength; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

