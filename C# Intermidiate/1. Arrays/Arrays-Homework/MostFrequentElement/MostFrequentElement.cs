using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentElement
{
    class MostFrequentElement
    {
        private class number 
        {
            public int num, count;
            public number(int n, int c)
            {
                this.num = n;
                this.count = c;
            }
        }
        static void Main()
        {
            string line = Console.ReadLine();
            string[] arrStr = line.Split(' ');
            int[] arr = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }
            List<number> seenNumbers = new List<number>();
            for (int i = 0; i < arr.Length; i++)
            {
                int j;
                for ( j = 0; j < seenNumbers.Count; j++)
                {
                    if (seenNumbers[j].num == arr[i])
                    {
                        seenNumbers[j].count++;
                        break;
                    }
                }
                if (j == seenNumbers.Count)
                {
                    number cNum = new number(arr[i], 1);
                    seenNumbers.Add(cNum);
                }
            }
            List<int> max = new List<int>();
            max.Add(0);
            for(int k = 1; k<seenNumbers.Count; k++)
            {
                if(seenNumbers[k].count>seenNumbers[max[0]].count)
                {
                    max.Clear();
                    max.Add(k);
                }
                if (seenNumbers[k].count == seenNumbers[max[0]].count && seenNumbers[k].num != seenNumbers[max[0]].num)
                {
                    max.Add(k);
                }
            }
            for (int k = 0; k < max.Count; k++)
            {
                Console.WriteLine("{0} is seen {1} times", seenNumbers[max[k]].num, seenNumbers[max[k]].count);
            }
        }
    }
}
