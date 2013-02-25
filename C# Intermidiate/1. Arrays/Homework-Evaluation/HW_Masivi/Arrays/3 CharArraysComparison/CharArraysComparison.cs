using System;

class CharArraysComparison
{
    static void Main()
    {
        sbyte result = 0; // 0 for equality, 1 for arr1 greater and -1 for arr2 greater

        int arr1Length, arr2Length;
        Console.Write("Enter the length of the first array: ");
        arr1Length = int.Parse(Console.ReadLine());
        Console.Write("Enter the length of the second array: ");
        arr2Length = int.Parse(Console.ReadLine());

        char[] arr1 = new char[arr1Length];
        char[] arr2 = new char[arr2Length];

        Console.WriteLine("");

        for (int i = 0; i < arr1Length; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr1[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("");

        for (int i = 0; i < arr2Length; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            arr2[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < Math.Min(arr1Length, arr2Length); i++)
        {
            if(arr1[i] < arr2[i])
            {
                result = 1;
                break;
            }
            else if(arr1[i] > arr2[i])
            {
                result = -1;
                break;
            }
        }

        if (result == 0)
        {
            if (arr1Length > arr2Length)
            {
                result = -1;
            }
            else if (arr1Length < arr2Length)
            {
                result = 1;
            }
        }

        switch (result)
        {
            case -1:
                Console.WriteLine("Array 2 is lexicographically shorter");
                break;
            case 0:
                Console.WriteLine("The arrays are equal");
                break;
            case 1:
                Console.WriteLine("Array 1 is lexicographically shorter");
                break;
            default:
                break;
        }
    }
}

