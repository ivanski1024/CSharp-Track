using System;

namespace FindSequenceEqualedToGivenSum
{
    public class FindTheSequence 
    {
        private int sumToFind;
        private int startIndex=0;
        private int endIndex=0;
        
        public int GetSum() 
        {
            return sumToFind;
        }
        public int GetStartIndex()
        {
            return startIndex;
        }
        public int GetEndIndex()
        {
            return endIndex;
        }
        public int[] Sort(int[] array) 
        {
            Array.Sort(array);
            return array;
        }
        public void Search(int searchFor, int[] array) 
        {
            int sum = 0;
            sumToFind=searchFor;
            for (int i = 0; i < array.Length-1; i++) 
            {
                startIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    sum += array[i] + array[j];
                    if (sum == searchFor)
                    {
                        sumToFind = sum;
                        endIndex = j;
                    }
                }    
            }
        }

    }
    public class FindSequenceEqualedToGivenSum
    {
        static void Main(string[] args)
        {
            int len = 0;
            int sumToFind = 0;
            Console.WriteLine("Enter the sum that must be found:");
            try
            {
                sumToFind = Int32.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid Input!");
                return;
            }
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
            FindTheSequence search = new FindTheSequence();
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
            }
            search.Sort(digits);
            Console.WriteLine();
            if (search.GetSum() == 0)
            {
                Console.WriteLine("The sum you've entered was not found!");
            }
            else 
            {
                for (int i = search.GetStartIndex(); i < search.GetEndIndex() - 1; i++)
                {
                    Console.Write(digits[i] + " , ");
                }                
            }
            for (int i = 0; i < digits.Length - 1; i++)
            {
                Console.Write(digits[i]+" , ");
            }
        }
    }
}
