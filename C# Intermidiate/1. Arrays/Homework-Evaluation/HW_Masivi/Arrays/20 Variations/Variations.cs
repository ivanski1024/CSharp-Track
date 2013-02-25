using System;
using System.Collections.Generic;

class Variations
{
    static int maxValue, variationPositions;

    static void PrintList(List<int> array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine("");
    }

    static void Variate(List<int> pivot, int placesRemaining)
    {
        if (placesRemaining == 1)
        {
            for (int i = 1; i <= maxValue; i++)
            {
                pivot.Add(i);
                PrintList(pivot);
                pivot.RemoveAt(variationPositions);
            }
            return;
        }



        for (int i = 1; i <= maxValue; i++)
        {
            List<int> tempPivot = new List<int>(pivot);

            tempPivot.Add(i);

            Variate(tempPivot, placesRemaining - 1); // recursive function call HERE
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the upper boundary of the set: ");
        maxValue = int.Parse(Console.ReadLine());
        Console.Write("Enter length of the variation subsets: ");
        variationPositions = int.Parse(Console.ReadLine());
        List<int> emptyList = new List<int>();

        Variate(emptyList, variationPositions);
    }
}