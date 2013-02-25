using System;
using System.Collections.Generic;

class MaximumArraySubsetSum
{
    static int FindGreatestArrayElement(List<int> listPointer, out int index)
    {
        int greatestElement = listPointer[0];
        index = 0;

        for (int i = 1; i < listPointer.Count; i++)
        {
            if (listPointer[i] > greatestElement)
            {
                greatestElement = listPointer[i];
                index = i;
            }
        }

        return greatestElement;
    }

    static void Main()
    {
        int n, k;
        int greatestSum = 0, greatestElementIndex;

        Console.Write("Enter the length of the array: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter the length of the subset: ");
        k = int.Parse(Console.ReadLine());

        List<int> resizeable = new List<int>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            resizeable.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < k; i++)
        {
            greatestSum += FindGreatestArrayElement(resizeable, out greatestElementIndex);
            resizeable.Remove(greatestElementIndex + 1);
        }

        Console.WriteLine("The greatest sum is {0}", greatestSum);
    }
}