using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SentencesWithIn
{
    class SentencesWithIn
    {
        static void Main()
        {
            string text;
            using (StreamReader file = new StreamReader("../../../file.txt"))
            {
                text = file.ReadToEnd();
            }
            string[] sentences = text.Split('.');
            
            for (int i=0; i<sentences.Length; i++)
            {
                if (Regex.Matches(sentences[i], @"\bin\b").Count!=0)
                {
                    sentences[i] = sentences[i].Trim();
                    sentences[i] = sentences[i].Insert(sentences[i].Length, ".");
                    Console.WriteLine(sentences[i]);
                }
            }
        }
    }
}
