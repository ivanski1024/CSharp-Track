using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequanceWithSumS
{
    class SequanceWithSumS
    {
        class sequance
        {
            public int first, length;
            public sequance(int f, int l)
            {
                this.first = f;
                this.length = l;
            }
        }
        static void Main()
        {
            string line = Console.ReadLine();
            int S = int.Parse(Console.ReadLine());
            string[] arrStr = line.Split(' ');
            int[] arr = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }
            List<sequance> seqWithSumS = new List<sequance>();
            for (int f = 0; f < arr.Length; f++)
            { 
                int currSum=0;
                int c = 0;
                while(f+c<arr.Length)
                {
                    currSum += arr[f + c];
                    c++;
                    if (currSum == S)
                    {
                        sequance Seq = new sequance(f, c);
                        seqWithSumS.Add(Seq);
                        if (f + c + 1 < arr.Length)
                        {
                            if (arr[f + c + 1] != 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            for (int s = 0; s < seqWithSumS.Count; s++)
            {
                for (int i = seqWithSumS[s].first; i < seqWithSumS[s].first + seqWithSumS[s].length; i++)
                {
                    if (i != seqWithSumS[s].first)
                    {
                        Console.Write("+");
                    }
                    if (arr[i] >= 0)
                    {
                        Console.Write("{0}", arr[i]);
                    }
                    else
                    {
                        Console.Write("({0})", arr[i]);
                    }
                }
                Console.WriteLine("={0}", S);
            }
        }
    }
}
