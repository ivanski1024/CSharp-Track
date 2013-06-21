namespace NestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RecursionTools;

    public static class NestedLoops
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            List<List<int>> combinations = GetNestedLoopsIndexCombinations(n);
            Console.WriteLine(Tools.Visualize<int>(combinations));
        }

        public static List<List<int>> GetNestedLoopsIndexCombinations(int n)
        {
            List<int> currArray = new List<int>(n);
            List<List<int>> combinations = new List<List<int>>();

            NestedLoop(n, combinations, currArray, 0);

            return combinations;
        }

        public static void NestedLoop(int n, List<List<int>> arrays, List<int> currArray, int currPosition)
        {
            if (currPosition == n)
            {
                arrays.Add(Tools.CopyList<int>(currArray));
            }
            else
            {
                for (int index = 1; index <= n; index++)
                {
                    currArray.Add(index);

                    NestedLoop(n, arrays, currArray, currPosition + 1);

                    currArray.RemoveAt(currPosition);
                }
            }
        }
    }
}