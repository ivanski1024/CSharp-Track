using System;

class BinarySearch
{
    static void Main()
    {
        int arrLength, element;
        Console.Write("Enter the length of the array: ");
        arrLength = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of the element: ");
        element = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLength];

        for (int i = 0; i < arrLength; i++) // console entry of the elements of the array
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        int minIndex = 0;
        int maxIndex = arrLength;
        int arrIndex = 0;
        bool stillSearching = true;
       
        while (stillSearching)
        {         
            if (arr[arrIndex] == element)
            {
                stillSearching = false;
            }
            else if (arr[arrIndex] > element)
            {
                maxIndex = arrIndex;
                arrIndex -= (maxIndex - minIndex) / 2;
            }
            else
            {
                minIndex = arrIndex;
                arrIndex += (maxIndex - minIndex) / 2;
            }
        }

        Console.WriteLine("Element {0} is on position {1} of the array.", element, arrIndex);
    }
}

