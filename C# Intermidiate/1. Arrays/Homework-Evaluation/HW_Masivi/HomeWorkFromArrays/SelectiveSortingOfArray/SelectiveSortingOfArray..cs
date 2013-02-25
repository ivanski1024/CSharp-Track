using System;

namespace SelectiveSortingOfArray
{
    public class FindSmallestElement
    {
        private int[] sortedArray;
        public void SetArrayElemts(int[] arrays)
        {
            for (int i = 0; i < arrays.Length; i++) 
            {
                sortedArray[i]=arrays[i];
            }
        }

        public void SetArraySize(int SIZE)
        {
            sortedArray = new int[SIZE];
        }

        public void PrintSortedArray()
        {
            for (int i = 1; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " , ");
            }
        }

        public void SortTheSmallestElements(int[] array)
        {   
            SetArraySize(array.Length);
            int i, j;
            int min, temp;

            for (i = 0; i < array.Length - 1; i++)
            {
                min = i;

                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;             
            }
            SetArrayElemts(array);
        }

    }
    class SelectiveSortingOfArray
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
                FindSmallestElement obj=new FindSmallestElement();
                for (int i = 0; i < len-1; i++) 
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
                obj.SortTheSmallestElements(digits);
                Console.WriteLine();
                obj.PrintSortedArray();
                Console.WriteLine();
        }
    }
}
