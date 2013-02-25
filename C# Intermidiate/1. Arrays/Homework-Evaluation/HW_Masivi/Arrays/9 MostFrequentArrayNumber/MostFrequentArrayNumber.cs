using System;
using System.Collections.Generic;

class MostFrequentArrayNumber
{
    struct ArrayNumber
    {
        public int Value;
        public uint Occurences;
    }

    static void Main(string[] args)
    {
        int arrLength;
        Console.Write("Enter the length of the array: ");
        arrLength = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLength];

        for (int i = 0; i < arrLength; i++) // console entry of the elements of the array
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        List<ArrayNumber> numbers = new List<ArrayNumber>();

        for (int i = 0; i < arrLength; i++) // place numbers and their respective occurences in a list of structures
        {
            bool numberExistsInList = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                ArrayNumber temp = numbers[j];
                if (temp.Value == arr[i])
                {
                    numberExistsInList = true;
                    temp.Occurences++;
                    numbers[j] = temp;
                }
            }

            if (!numberExistsInList)
            {
                ArrayNumber temp;
                temp.Value = arr[i];
                temp.Occurences = 1;
                numbers.Add(temp);
            }           
        }

        ArrayNumber numberWithMostOccurences = new ArrayNumber();
        
        foreach (var number in numbers) // iterate over the list of numbers and find the one with most occurences
        {
            if (number.Occurences > numberWithMostOccurences.Occurences)
            {
                numberWithMostOccurences = number;
            }                
        }

        Console.WriteLine("");
        Console.WriteLine("Number {0} has occured most frequently in the array, namely {1} times.", numberWithMostOccurences.Value, numberWithMostOccurences.Occurences);
    }
}