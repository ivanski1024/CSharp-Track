using System;
using System.Collections.Generic;

class Permutations
{
    static int printCounter = 1;

    static void PrintList(List<int> list)
    {
        Console.Write(printCounter++ + ": ");

        foreach (var element in list)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine("");
    }

    static void Permute(List<int> pivot, List<int> toBePermuted)
    {
        if (toBePermuted.Count == 1)
        {
            pivot.Add(toBePermuted[0]);
            PrintList(pivot);
            return;
        }



        for (int i = 0; i < toBePermuted.Count; i++)
        {
            List<int> tempPivot = new List<int>(pivot);
            List<int> tempToBePermuted = new List<int>(toBePermuted);

            int value = toBePermuted[i];
            tempPivot.Add(value);
            tempToBePermuted.RemoveAt(i);
             
            Permute(tempPivot, tempToBePermuted); // recursive function call HERE
        }
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        List<int> permutableArray = new List<int>();
        List<int> permutedBillet = new List<int>();

        for (int i = 0; i < n; i++)
        {
            permutableArray.Add(i + 1);
        }

        Permute(permutedBillet, permutableArray);
    }
}