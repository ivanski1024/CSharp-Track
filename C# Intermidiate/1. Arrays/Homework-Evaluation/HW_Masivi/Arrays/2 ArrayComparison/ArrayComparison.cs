using System;

class ArrayComparison
{
    static void Main()
    {
        bool equal = true;
        int arr1Length, arr2Length;
        Console.Write("Enter the length of the first array: ");
        arr1Length = int.Parse(Console.ReadLine());
        Console.Write("Enter the length of the second array: ");
        arr2Length = int.Parse(Console.ReadLine());

        int[] arr1 = new int[arr1Length];
        int[] arr2 = new int[arr2Length];

        for (int i = 0; i < arr1Length; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr2Length; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            arr2[i] = int.Parse(Console.ReadLine());
        }

        if (arr1Length != arr2Length)
        {
            equal = false;
        }

        for (int i = 0; i < Math.Min(arr1Length, arr2Length); i++)
        {
            if (arr1[i] != arr2[i])
            {
                equal = false;
            }
        }

        Console.WriteLine("Arrays are identical: {0}", equal);
    }
}