using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    class Variations
    {
        static StringBuilder VariationsString = new StringBuilder();
        static int n, k;
        static void Main()
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            k = int.Parse(Console.ReadLine());
            int[] HowAreNumbersSelected = new int[k];
            GiveMeTheVariations(HowAreNumbersSelected, 0);
            Console.WriteLine(VariationsString);
        }
        static void GiveMeTheVariations(int[] selected, int count)
        {
            if (count == k)
            {
                PrintArray(selected);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    selected[count] = i + 1;
                    GiveMeTheVariations(selected, count + 1);
                }
            }
        }
        static void PrintArray(int[] selected)
        {
            for (int i = 0; i < k; i++)
            {
                VariationsString.Append(selected[i]);
                VariationsString.Append(' ');
            }
            VariationsString.Append('\n');
        }
    }
}
