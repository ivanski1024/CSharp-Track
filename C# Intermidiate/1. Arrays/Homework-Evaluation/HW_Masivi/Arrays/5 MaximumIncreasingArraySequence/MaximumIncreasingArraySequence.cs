using System;

class MaximumIncreasingArraySequence
{
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

        int previousElement = arr[0], maximumSequenceLength = 1, sequenceLength = 1, largestSequenceElement = arr[0];

        for (int i = 1; i < arrLength; previousElement = arr[i++])
        {
            if (arr[i] == (previousElement + 1))
            {
                if (++sequenceLength > maximumSequenceLength)
                {
                    maximumSequenceLength = sequenceLength;
                    largestSequenceElement = arr[i];
                }
            }
            else
            {
                sequenceLength = 1;
            }
        }

        Console.WriteLine("The maximum sequence is:");
        for (int i = 0; i < maximumSequenceLength; i++)
        {
            Console.Write("{0} ", (largestSequenceElement - maximumSequenceLength + i + 1));
        }
    }
}

