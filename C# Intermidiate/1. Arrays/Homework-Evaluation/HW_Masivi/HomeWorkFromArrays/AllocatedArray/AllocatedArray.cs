using System;

namespace AllocatedArray
{
    class AllocatedArray
    {
        static void Main(string[] args)
        {
            int[] digits = new int[20];
            for (int i = 0; i <= digits.Length-1; i++) 
            {
               digits[i]=(i * 5);
            }
            for (int i = 0; i <= digits.Length-1; i++)
            {
                Console.WriteLine(digits[i]);
            }
        }
    }
}
