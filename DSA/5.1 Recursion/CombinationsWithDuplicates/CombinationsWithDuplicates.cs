namespace CombinationsWithDuplicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RecursionTools;

    public static class CombinationsWithDuplicates
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            List<List<int>> combinations = GetCombinationsWithDuplicates(n, k);
            Console.WriteLine(Tools.Visualize<int>(combinations));
        }

        private static List<List<int>> GetCombinationsWithDuplicates(int n, int k)
        {
            List<List<int>> combinations = new List<List<int>>();
            List<int> currCombination = new List<int>();
            GetCombinationsWithDuplicates(combinations, currCombination, n, k, 1);
            return combinations;
        }

        private static void GetCombinationsWithDuplicates(List<List<int>> combinations, List<int> currCombination, int n, int k, int CurrEl)
        {
            if (currCombination.Count == k)
            {
                combinations.Add(Tools.CopyList<int>(currCombination));
            }
            else
            {
                for (int el = CurrEl; el <= n; el++)
                {
                    currCombination.Add(el);

                    GetCombinationsWithDuplicates(combinations, currCombination, n, k, el);

                    currCombination.RemoveAt(currCombination.Count - 1);
                }
            }
        }
    }
}
