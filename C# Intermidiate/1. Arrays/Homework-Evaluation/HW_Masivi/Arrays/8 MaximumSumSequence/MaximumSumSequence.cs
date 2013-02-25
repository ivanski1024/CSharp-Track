using System;

class MaximumSumSequence
{
    static void Main(string[] args)
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

        int maximumSum = 0;
        int here = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            here = (here + arr[i] > 0) ? here + arr[i] : 0;
            maximumSum = (here > maximumSum) ? here : maximumSum;
        }


        Console.WriteLine(maximumSum);
        
    }
}