using System;

namespace FindLongestSequenceOfBiggerElements
{
    class FindLongestSequenceOfBiggerElements
    {
        static void Main(string[] args)
        {
            int len = 0, digitsInput = 0, counter = 0;
            Console.WriteLine("Enter the how many digits you will enter from the console");
            if (Int32.TryParse(Console.ReadLine(), out len))
            {
                int[] digits = new int[len];
                int matchedIndex = 0;
                int longestMatch = 1;
                for (int i = 0; i < digits.Length; i++)
                {
                    if (Int32.TryParse(Console.ReadLine(), out digitsInput))
                    {
                        digits[i] = digitsInput;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                for (int j = 0; j < digits.Length - 1; j++)
                {
                    for (int i = j; i < digits.Length; i++)
                    {
                        if (digits[i] > digits[j])
                        {
                            counter++;
                        }
                        else 
                        {
                            counter = 0;
                        }
                    }
                    if (counter > longestMatch)
                    {
                        longestMatch = counter;
                        matchedIndex = j+1;
                    }
                    counter = 0;
                }
                Console.WriteLine("The longest sequence of equal elements is: \n");

                for (int j = matchedIndex, i = 0; i < longestMatch; i++, j++)
                {
                    Console.Write(digits[j] + " , ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return;
            }
        }
    }
}
