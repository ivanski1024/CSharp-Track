using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            char[] word1Copy = new char[word1.Length];
            char[] word2Copy = new char[word2.Length];
            int length = word1.Length < word2.Length ? word1.Length : word2.Length;
            bool same=true;
            int firstDifferent=-1;
            for (int i = 0; i < length; i++)
            {
                if (word1[i] >= 'A' && word1[1] <= 'Z')
                {
                    word1Copy[i] = (char)(word1[i] - 'A' + 'a');
                }
                else
                {
                    word1Copy[i] = word1[i];
                }
                if (word2[i] >= 'A' && word2[1] <= 'Z')
                {

                    word2Copy[i] = (char)(word2[i] - 'A' + 'a');
                }
                else
                {
                    word2Copy[i] = word2[i];
                }


                if (word1Copy[i] != word2Copy[i])
                {
                    same = false;
                    firstDifferent = i;
                    break;
                }
            }
            if (!same)
            {
                if (word1Copy[firstDifferent] < word2Copy[firstDifferent])
                {
                    Console.WriteLine(word1);
                    Console.WriteLine(word2);
                }
                else
                {
                    Console.WriteLine(word2);
                    Console.WriteLine(word1);
                }
            }
            else
            {
                if (word1.Length <= word2.Length)
                {
                    Console.WriteLine(word1);
                    Console.WriteLine(word2);
                }
                else
                {
                    Console.WriteLine(word2);
                    Console.WriteLine(word1);
                }
            }
        }
    }
}
