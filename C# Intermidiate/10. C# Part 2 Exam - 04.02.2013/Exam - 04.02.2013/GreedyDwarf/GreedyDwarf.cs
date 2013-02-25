using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        static void Main()
        {
            string[] seperator = { ", " };
            string valleyString = Console.ReadLine();
            string[] valleyElements = valleyString.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            int[] valley = new int[valleyElements.Length];
            for (int i = 0; i < valleyElements.Length; i++)
            {
                valley[i] = int.Parse(valleyElements[i]);
            }
            int pCount = int.Parse(Console.ReadLine());
            int[][] patterns = new int[pCount][];
            for (int i = 0; i < pCount; i++)
            {
                string currPattern = Console.ReadLine();
                string[] currPatternElements = currPattern.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                patterns[i] = new int[currPatternElements.Length];
                for (int j = 0; j < currPatternElements.Length; j++)
                {
                    patterns[i][j] = int.Parse(currPatternElements[j]);
                }
            }
            int max=0, curr;
            for (int i = 0; i < pCount; i++)
            {
                if (i == 0)
                {
                    max = GetCoins(valley, patterns[i]);
                }
                else
                {
                    curr = GetCoins(valley, patterns[i]);
                    if (curr > max)
                    {
                        max = curr;
                    }
                }
            }
            Console.WriteLine(max);
        }

        private static int GetCoins(int[] valley, int[] pattern)
        {
            bool[] taken = new bool[valley.Length];
            int coins = 0;
            int currPattern = 0;
            int pos =0;

            while (true)
            {
                if (!taken[pos])
                {
                    coins += valley[pos];
                    taken[pos] = true;
                    if (pos + pattern[currPattern] >= 0 && pos + pattern[currPattern] < valley.Length)
                    {
                        pos += pattern[currPattern];
                        if (currPattern < pattern.Length - 1)
                        {
                            currPattern++;
                        }
                        else
                        {
                            currPattern = 0;
                        }
                    }
                    else
                    {
                        return coins;
                    }
                }
                else
                {
                    return coins;
                }
            }
            return coins;
        }
    }
}
