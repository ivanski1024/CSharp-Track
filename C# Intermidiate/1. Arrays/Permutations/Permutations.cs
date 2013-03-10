using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Permutations
    {
        static StringBuilder PermutationsString = new StringBuilder();
        static int n;
        static void Main()
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());

            DateTime startTime = DateTime.Now;
            bool[] IsThisNumberSelected = new bool[n];
            int[] HowAreNumbersSelected = new int[n];
            GiveMeThePermutations(IsThisNumberSelected, HowAreNumbersSelected, 0);
            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;
            PermutationsString.Append("Execution Time 2: ");
            PermutationsString.Append(duration.Milliseconds);
            Console.WriteLine(PermutationsString);
        }
        static void GiveMeThePermutations(bool[] numbers, int[] selected, int count)
        {
            if (count == n)
            {
                PrintArray(selected);   // If the count of currently selected elements is equal to the count of all the numbers it prints out the current selection.
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!numbers[i])
                    {
                        numbers[i] = true;
                        selected[count] = i + 1;
                        GiveMeThePermutations(numbers, selected, count + 1);
                        numbers[i] = false;
                    }
                }
            }
        }
        static void PrintArray(int[] selected)
        {
            for (int i = 0; i < n; i++)
            {
                //Console.Write("{0} ", selected[i]);
                PermutationsString.Append(selected[i]);
                PermutationsString.Append(' ');
            }
            //Console.WriteLine();
            PermutationsString.Append('\n');
        }
    }
}
