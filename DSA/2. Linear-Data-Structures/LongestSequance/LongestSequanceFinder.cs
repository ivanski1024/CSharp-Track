using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequance
{
    public static class LongestSequanceFinder
    {
        public static void Main()
        { 
        }

        public static List<int> FindLongestSequance(List<int> list)
        {
            if(list.Count == 0)
            {
                return new List<int>();
            }

            int longestCount = 1;
            int longestElement = list[0];
            int currentCount = 1;
            int index=1;
            while (index < list.Count)
            {
                if (list[index] == list[index - 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > longestCount)
                    {
                        longestCount = currentCount;
                        currentCount = 1;
                        longestElement = list[index - 1];
                    }
                }
                index++;
            }
            if (currentCount > longestCount)
            {
                longestCount = currentCount;
                longestElement = list[index - 1];
            }
            List<int> output = new List<int>();
            for (int i = 0; i < longestCount; i++)
            {
                output.Add(longestElement);
            }
            return output;
        }
    }
}
