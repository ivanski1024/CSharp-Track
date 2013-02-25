using System;


namespace ComparingCharArraysLexicographically
{
    class ComparingCharArraysLexicographically
    {
        static void Main(string[] args)
        {
            char[] array1;
            char[] array2;
            int sizeOfArray1 = 0, sizeOfArray2 = 0, arrayLength = 0;

            Console.WriteLine("Enter the size of first array");
            sizeOfArray1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of second array");
            sizeOfArray2 = Int32.Parse(Console.ReadLine());

            array1 = new char[sizeOfArray1];
            array2 = new char[sizeOfArray2];

            if (sizeOfArray1 > sizeOfArray2)
            {
                arrayLength = sizeOfArray2;
            }
            else if (sizeOfArray2 > sizeOfArray1)
            {
                arrayLength = sizeOfArray1;
            }
            else 
            {
                arrayLength = (sizeOfArray1+sizeOfArray2)/2;
            }
            for (int i = 0; i <= sizeOfArray1 - 1; i++)
            {
                Console.WriteLine("Enter digits for first array:");
                array1[i] = Char.Parse(Console.ReadLine());
            }
            for (int j = 0; j <= sizeOfArray2 - 1; j++)
            {
                Console.WriteLine("Enter digits for second array:");
                array2[j] = Char.Parse(Console.ReadLine());
            }


            for (int i = 0; i <= arrayLength - 1; i++) 
            {
                if (array1[i] >= array2[i])
                {
                    Console.WriteLine("Array2 is lexicographically smaller than array1");
                }
                else if (array1[i] <= array2[i])
                {
                    Console.WriteLine("Array1 is lexicographically smaller than array2");
                }
            }
        }
    }
}
