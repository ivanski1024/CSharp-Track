using System;
class Program
{
    static void Main()
    {
        for (int i = 1; i < 8; i++)
        {
            for (int j = -1; j < 16; j++)
            { 
                if((i==1))
                {
                    if(j==-1)
                        Console.Write("  ");
                    else
                        Console.Write(j.ToString("X"));
                }
                else
                {
                    if(j==-1)
                        Console.Write(" " + i);
                    else
                        Console.Write((char)(i*16+j));
                }
                Console.Write(" | ");
            }
            Console.WriteLine();
            for (int j = -1; j < 67; j++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }
    }
}