using System;

namespace FindKElementsWithMaxSum
{
    class FindKElementsWithMaxSum
    {
        static void Main(string[] args)
        {
            int inputK = 0, inputN=0, k=0 ,n = 0,sum=0;
            Console.WriteLine("Enter N:");
            if (Int32.TryParse(Console.ReadLine(), out inputK) && Int32.TryParse(Console.ReadLine(), out inputN))
            {
                k = inputK;
                n = inputN;
                int[] digits = new int[n];
                int[] sums = new int[n];
                for (int i = 0; i < digits.Length; i++) 
                {
                    for (int j = i; j < k; j++)
                    {
                        sum += digits[i] + digits[j];
                    }
                    sums[i]=sum;
                }
                Array.Sort(sums);
            }
            else 
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
