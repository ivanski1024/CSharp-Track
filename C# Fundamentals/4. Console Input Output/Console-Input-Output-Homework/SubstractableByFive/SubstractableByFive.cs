using System;
class SubstractableByFive
{
    static void Main()
    {
        int first, last, count=0;
        first = Convert.ToInt32(Console.ReadLine());
        last = Convert.ToInt32(Console.ReadLine());
        if ((first % 5 == 0) || (first*last<0)&&(first%5!=0)) count++;
        Console.WriteLine( count+Math.Abs(last/5-first/5)  );
    }
}