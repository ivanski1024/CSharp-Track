using System;
class Program
{
    static void Main()
    {
        char copyRight='\u00a9';
        char empty='\u0000';
        for (int i = 0; i < 3 ; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if((j<3-i)||(j>3+i))
                { Console.Write(empty); }
                else
                { Console.Write(copyRight); }
            }
            Console.WriteLine();
        }
    }
}
