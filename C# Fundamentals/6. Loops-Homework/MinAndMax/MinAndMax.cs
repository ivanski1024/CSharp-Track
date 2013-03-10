using System;
using System.Collections;
class MinAndMax
{
    static void Main()
    {
        ArrayList numbers = new ArrayList();
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        int min=0, max=0;
        Console.WriteLine("Enter {0} numbers", n);
        for (int i = 0; i < n; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine() ) );
            if (i == 0)
            {
                min = (int)numbers[i];
                max = (int)numbers[i];
            }
            else
            {
                if ((int)numbers[i] < min) min = (int)numbers[i];
                if ((int)numbers[i] > max) max = (int)numbers[i];
            }
        }
        Console.WriteLine("The min number is {0} and the max number is {1}", min, max);
        
    }
}
