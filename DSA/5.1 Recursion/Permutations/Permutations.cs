namespace Permutations
{
    using RecursionTools;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Permutations
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            List<List<int>> permutations = GetPermutations(n);
            Console.WriteLine(Tools.Visualize(permutations));
        }

        private static List<List<int>> GetPermutations(int n)
        {
            List<List<int>> permutations = new List<List<int>>();
            List<int> currPermutation = new List<int>();
            bool[] usedElements = new bool[n];
            GetPermutations(permutations, currPermutation, n, usedElements);
            return permutations;
        }

        private static void GetPermutations(List<List<int>> permutations, List<int> currPermutation, int n, bool[] usedElements)
        {
            if (currPermutation.Count == n)
            {
                permutations.Add(Tools.CopyList<int>(currPermutation));
            }
            else
            {
                for (int index = 0; index < n; index++)
                {
                    if (!usedElements[index])
                    {
                        usedElements[index] = true;
                        currPermutation.Add(index + 1);
                        GetPermutations(permutations, currPermutation, n, usedElements);
                        currPermutation.RemoveAt(currPermutation.Count - 1);
                        usedElements[index] = false;
                    }
                }
            }
        }
    }
}
