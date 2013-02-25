using System;

namespace FindSequenceWithMaxSum
{
    public class FindTheMaxSum
    {
        private int maxSum = Int32.MinValue;
        private int startIndex=0;
        private int endIndex = 1;

        public int GetMaxSum() 
        {
            return maxSum;
        }
        
        public int GetStartIndex() 
        {
            return startIndex;
        }
        
        public int GetEndIndex()
        {
            return endIndex;
        }

        public void FindMaxSum(int[] array) 
        {
            int sum = 0;
            for (int i =1; i < array.Length; i++) 
            {
                   sum = array[i] + array[i-1];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        startIndex = i-1;
                        endIndex = i;
                    }                
            }
        }

    }

    public class FindSequenceWithMaxSum
    {
        static void Main(string[] args)
        {
            int len = 0;
            Console.WriteLine("Enter how many digits you will enter:");
            try
            {
                len = Int32.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid Input!");
                return;
            }
            int[] digits = new int[len];
            FindTheMaxSum sum = new FindTheMaxSum();
            for (int i = 0; i < len - 1; i++)
            {
                try
                {
                    Console.WriteLine("Enter a digit:");
                    digits[i] = Int32.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Invalid Input!");
                    return;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of range!");
                    return;
                }
            }
            sum.FindMaxSum(digits);
            Console.WriteLine("\nMax sum is: {0}\n", sum.GetMaxSum());
            for (int i = sum.GetStartIndex(); i < sum.GetEndIndex(); i++) 
            {
                Console.Write(digits[i] + " , ");
            }
        }
    }
}
