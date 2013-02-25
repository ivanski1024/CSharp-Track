using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class Lines
    {
        static void Main()
        {
            byte[,] table = new byte[8, 8];
            byte boof;
            byte currLineLength = 0, maxLineLength = 0, maxLineCount = 0;
            for (int i = 0; i < 8; i++)
            {
                boof = byte.Parse(Console.ReadLine());
                for (int j = 0; j < 8; j++)
                {
                    table[i, 7 - j] = (byte)((boof & (1 << j)) >> j);


                    if (table[i, 7 - j] == 1)
                    {
                        currLineLength++;
                    }


                    else if (currLineLength > 0)
                    {
                        if (currLineLength > maxLineLength)
                        {
                            maxLineLength = currLineLength;
                            maxLineCount = 1;
                        }
                        else if (currLineLength == maxLineLength)
                        {
                            maxLineCount++;
                        }
                        currLineLength = 0;
                    }

                }
                if (currLineLength > 0)
                {
                    if (currLineLength > maxLineLength)
                    {
                        maxLineLength = currLineLength;
                        maxLineCount = 1;
                    }
                    else if (currLineLength == maxLineLength)
                    {
                        maxLineCount++;
                    }
                    currLineLength = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (table[7 - j, i] == 1)
                    {
                        currLineLength++;
                    }
                    else if (currLineLength > 0)
                    {
                        if (currLineLength > maxLineLength)
                        {
                            maxLineLength = currLineLength;
                            maxLineCount = 1;
                        }
                        else if (currLineLength == maxLineLength)
                        {
                            maxLineCount++;
                        }
                        currLineLength = 0;
                    }
                }
                if (currLineLength > 0)
                {
                    if (currLineLength > maxLineLength)
                    {
                        maxLineLength = currLineLength;
                        maxLineCount = 1;
                    }
                    else if (currLineLength == maxLineLength)
                    {
                        maxLineCount++;
                    }
                    currLineLength = 0;
                }
            }
            if (maxLineLength == 1)
            {
                maxLineCount /= 2;
            }
            Console.WriteLine(maxLineLength);
            Console.WriteLine(maxLineCount);
        }
    }
}
