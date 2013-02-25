using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJustification
{
    class ConsoleJustification
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                stringBuilder.Append(Console.ReadLine());
                if (i != n - 1) 
                {
                    stringBuilder.Append(" ");
                }
            }

            string text = Convert.ToString(stringBuilder);
            string[] seperators = {" "};
            string[] words = text.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            int wordsCount=0;
            while (wordsCount < words.Length)
            {
                int lineLength = 0;
                int wordsOnLine = 0;
                do
                {
                    if (wordsOnLine != 0)
                    {
                        lineLength += 1;
                    }
                    if (lineLength + words[wordsCount + wordsOnLine].Length <= w)
                    {
                        lineLength += words[wordsCount + wordsOnLine].Length;
                        wordsOnLine++;
                    }
                    else
                    {
                        break;
                    }
                } while (wordsCount+wordsOnLine<words.Length);

                if (wordsOnLine != 1)
                {

                    lineLength = 0;
                    for (int k = wordsCount; k < wordsCount + wordsOnLine; k++)
                    {
                        lineLength += words[k].Length;
                    }
                    int spaceLength = (w - lineLength) / (wordsOnLine - 1);
                    int add = (w - lineLength) % (wordsOnLine - 1);
                    for (int k = wordsCount; k < wordsCount + wordsOnLine; k++)
                    {
                        Console.Write(words[k]);
                        if (k != wordsCount + wordsOnLine - 1)
                        {
                            String whitespace;
                            if (add > 0)
                            {
                                whitespace = new String(' ', spaceLength + 1);
                                add--;
                            }
                            else
                            {
                                whitespace = new String(' ', spaceLength);
                            }
                            Console.Write(whitespace);
                        }
                        else
                        {
                            Console.WriteLine();
                        }

                    }

                    wordsCount += wordsOnLine;
                }
                else
                {
                    Console.WriteLine(words[wordsCount]);
                    wordsCount++;
                }
            }
        }
    }
}
