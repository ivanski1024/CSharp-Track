using System;
using System.Collections.Generic;

namespace FindinEqualElements
{
    class FindinEqualElements
    {
        static void Main(string[] args)
        {
            int len = 10, digitsInput = 0, counter = 0, start = 0;
            Console.WriteLine("Enter the how many digits you will enter from the console");
            if (len==10)//Int32.TryParse(Console.ReadLine(), out len))
            {
               int[] digits = { 1, 3, 4, 2, 2, 2, 3, 3, 4, 4 };//new int[len];
               int matchedIndex = 0;
               int longestMatch = 1;
               bool firstMatched = true;
              /* for (int i = 0; i < digits.Length; i++)
                {
                    if (Int32.TryParse(Console.ReadLine(), out digitsInput))
                    {
                        digits[i] = digitsInput;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }*/
                for (int j = 0; j < digits.Length-1; j++)
                {
                        if (digits[j] == digits[j+1])
                        {
                            counter++;
                            start = 0;
                        }
                        else 
                        {
                            start = j;
                            counter = 0;
                        }
                        if (counter > longestMatch)
                        {
                            longestMatch = counter;
                            matchedIndex = start+1;
                        }
                }  
                Console.WriteLine("The longest sequence of equal elements is: \n");

                    for (int i = matchedIndex; i <digits.Length-longestMatch; i++)
                    {
                        Console.Write(digits[i] + " , ");
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
