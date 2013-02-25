using System;
using System.IO;

class SieveOfEratosthenes
{
    const int UpperBoundary = 10000001;

    static void Main(string[] args)
    {
        bool[] primeNumbers = new bool[UpperBoundary];

        for (int i = 0; i < UpperBoundary; i++)
        {
            primeNumbers[i] = true;
        }

        int max = (int) Math.Sqrt(UpperBoundary);

        for (int i = 2; i < max; i++)
        {
            if (primeNumbers[i])
            {
                int multiple = i;
                int product = multiple + multiple;

                while (product < UpperBoundary)
                {
                    primeNumbers[product] = false;
                    product += multiple;
                }
            }
        }

        StreamWriter fileStream = new StreamWriter("primes.txt");
        int counter = 0;

        for (int i = 2; i < UpperBoundary; i++)
        {
            if (primeNumbers[i])
            {
                fileStream.WriteLine(i);
                counter++;
            }
        }

        Console.WriteLine("The total number of prime numbers lesser than {0} is {1}", UpperBoundary-1, counter);
        Console.WriteLine("Look for full list in the txt file!");
    }
}

