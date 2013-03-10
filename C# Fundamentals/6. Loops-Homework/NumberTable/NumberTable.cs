using System;
class NumberTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(n<=5)

                    Console.Write("{0} ", i + j + 1);
                else
                    Console.Write("{0, 2} ", i + j + 1);
            }
            Console.WriteLine();
        }
    }
}
