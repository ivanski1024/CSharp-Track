using System;

class SequenceWithGivenSum
{
    static void PrintArraySubset(int[] array, int firstElement, int lastElement)
    {
        for (int i = firstElement; i <= lastElement; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("");
    }

    static void Main(string[] args)
    {
        int arrLength, sum;
        Console.Write("Enter the length of the array: ");
        arrLength = int.Parse(Console.ReadLine());
        Console.Write("Enter the sum of the sequences you're looking for: ");
        sum = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLength];

        for (int i = 0; i < arrLength; i++) // console entry of the elements of the array
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrLength; i++)
        {
            int currentSum = 0;

            for (int j = i; j < arrLength; j++)
            {
                currentSum += arr[j];

                if (currentSum == sum)
                {
                    PrintArraySubset(arr, i, j);
                }
            }
        }
    }
}

