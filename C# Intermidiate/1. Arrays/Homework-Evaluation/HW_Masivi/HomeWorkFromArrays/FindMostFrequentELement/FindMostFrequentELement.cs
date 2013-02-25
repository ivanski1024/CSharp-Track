using System;

namespace FindMostFrequentELement
{
    public class ElementFrequency 
    {
        private int foundElements=0;
        private int element = 0;

        public int GetFoundElements() 
        {
            return foundElements;
        }

        public int GetElement()
        {
            return element;
        }

        public void SearchForElement(int[] array) 
        {
            int counter = 0;
            for (int i = 0; i < array.Length-1; i++) 
            {
                 for (int j=i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }
                if(foundElements<counter)
                {
                    foundElements = counter;
                    element = array[i];
                }
                counter = 0;
            }
        }
    }
    public class FindMostFrequentELement
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
            ElementFrequency elementObject = new ElementFrequency();
            for (int i = 0; i < len; i++)
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
            elementObject.SearchForElement(digits);
            Console.WriteLine("Element {0} is found {1} time.", elementObject.GetElement(), elementObject.GetFoundElements());
        }
    }
}
