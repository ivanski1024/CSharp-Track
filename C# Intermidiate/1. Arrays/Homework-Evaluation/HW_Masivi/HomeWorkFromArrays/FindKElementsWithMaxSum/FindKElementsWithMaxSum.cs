using System;

namespace FindKElementsWithMaxSum
{
    class FindKElementsWithMaxSum
    {
        static void Main(string[] args)
        {
            int inputK = 0, inputN=0, k = 0 ,n = 0,sum=0,maxSum=Int32.MinValue,startIndex=0,endIndex=1;
            Console.WriteLine("Enter N:");
            Console.WriteLine("Enter K:");
            if (Int32.TryParse(Console.ReadLine(), out inputK) && Int32.TryParse(Console.ReadLine(), out inputN))
            {
                k = inputK;
                n = inputN;
                int[] digits = {3,2,5,-1,4,5,-6,7};
                int[] elements = new int[n];
                for (int i = 0; i < digits.Length; i++) 
                {
                    digits[i] = Int32.Parse(Console.ReadLine());                      
                }
                    for (int i = k + 1; i < n; ++i)
                    {
                        sum = digits[i] + digits[i - k - 1];
                        if (maxSum < sum)
                        {
                            maxSum = sum;
                            startIndex = i - k - 1;
                            endIndex = i - 2;
                        }
                    }
                Console.WriteLine("MaxSum is: {0}", maxSum);
                Console.Write("And the sequence is: ");
                for (int l = startIndex; l <= endIndex; l++) 
                {
                    Console.Write(digits[l]+" , ");
                }
            }
            else 
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
