using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Combinations
    {
        static StringBuilder CombinationsString = new StringBuilder();
        static int n, k;
        static void Main()
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            k = int.Parse(Console.ReadLine());
            int[] HowAreNumbersSelected = new int[k];
            bool[] IsThisNumberSelected = new bool[n];
            GiveMeTheCombinations(-1, HowAreNumbersSelected, 0);
            Console.WriteLine(CombinationsString);
        }
        static void GiveMeTheCombinations(int lastSelected, int[] selected, int count)
        {
            if (count == k)
            {
                PrintArray(selected);
            }
            else
            {
                for (int i = lastSelected+1; i < n; i++)
                {
                        selected[count] = i + 1;
                        GiveMeTheCombinations(i, selected, count + 1);
                }
            }
        }
        static void PrintArray(int[] selected)
        {
            for (int i = 0; i < k; i++)
            {
                CombinationsString.Append(selected[i]);
                CombinationsString.Append(' ');
            }
            CombinationsString.Append('\n');
        }
    }
}
