using System;
class SumOfSubsets
{
    static void Main()
    {
        int[] numbers = new int[5];
        int[] bits = new int[5];
        int subsetSum;
        //bool ima_li_suma_ravna_na_0 = false;
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= 31; i++)
        {
            subsetSum = 0;
            for(int j=0; j<5; j++)
            {
                bits[j] = ((i & (1 << j)) >> j);
                subsetSum += bits[j] * numbers[j];
            }
            if ( subsetSum == 0 )
            {
                Console.WriteLine("There is a subset of numbers with sum equal to 0.");
                return;
            }
        }
        //if(ima_li_suma_ravna_na_0==false)
        Console.WriteLine("There is NOT a subset of numbers with sum equal to 0.");
    }
}