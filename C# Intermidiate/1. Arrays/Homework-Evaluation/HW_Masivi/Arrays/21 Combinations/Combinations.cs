using System;
using System.Collections.Generic;

class Combinations
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

    static void Combine(List<int> pivot, List<int> toBeCombined, int placesRemaining)
    {
        if (placesRemaining == 1)
        {
            for (int i = 0; i < toBeCombined.Count; i++)
            {
                pivot.Add(toBeCombined[i]);
                PrintList(pivot);
                pivot.RemoveAt(variationPositions - 1);
            }
            return;
        }

        for (int i = 0; i < toBeCombined.Count; i++)
        {
            List<int> tempPivot = new List<int>(pivot);
            List<int> tempToBeCombined = new List<int>(toBeCombined);

            int value = toBeCombined[i];
            tempPivot.Add(value);
            tempToBeCombined.RemoveAt(i);

            Combine(tempPivot, tempToBeCombined, placesRemaining - 1); // recursive function call HERE
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the upper boundary of the set: ");
        maxValue = int.Parse(Console.ReadLine());
        Console.Write("Enter length of the variation subsets: ");
        variationPositions = int.Parse(Console.ReadLine());
        List<int> emptyPivotalList = new List<int>();
        List<int> listToBeCombined = new List<int>(maxValue);

        for (int i = 0; i < maxValue; i++)
        {
            listToBeCombined.Add(i + 1);
        }

        Combine(emptyPivotalList, listToBeCombined, variationPositions);
    }
}