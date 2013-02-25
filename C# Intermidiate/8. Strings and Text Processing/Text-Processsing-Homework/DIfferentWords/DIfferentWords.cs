using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIfferentWords
{
    class DIfferentWords
    {
        static void Main()
        {
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();
            string[] seperators = { " ", ".", ",", "!", "?", ":", ";" };
            string[] words = text.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            List<string> SeenWords = new List<string>();
            List<int> TimesSeen = new List<int>();
            foreach (string word in words)
            {
                if (SeenWords.IndexOf(word) == -1)
                {
                    SeenWords.Add(word);
                    TimesSeen.Add(1);
                }
                else
                {
                    TimesSeen[SeenWords.IndexOf(word)]++;
                }
            }
            for (int i = 0; i < SeenWords.Count; i++)
            {
                Console.WriteLine("\"{0}\" - {1}", SeenWords[i], TimesSeen[i]);
            }
        }
    }
}
