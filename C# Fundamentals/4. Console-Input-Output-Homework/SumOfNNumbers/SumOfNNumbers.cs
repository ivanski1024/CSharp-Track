using System;
class SumOfNNumbers
{
    static void Main()
    {
        int n=Convert.ToInt32(Console.ReadLine());
        decimal sum=0;
        for (int i = 0; i < n; i++)
            sum += Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine(sum);
    }
}