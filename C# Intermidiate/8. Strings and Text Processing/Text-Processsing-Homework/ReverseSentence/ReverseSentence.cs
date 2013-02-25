using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class ReverseSentence
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            StringBuilder reversed = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversed.Append(words[i]);
                if (i != 0)
                {
                    reversed.Append(' ');
                }
            }
            Console.WriteLine(reversed);
        }
    }
}
