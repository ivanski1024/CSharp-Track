using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Calculator2
    {
        static void Main()
        {
            int[] arr = GetArray();
            Console.WriteLine("The minimum is: {0}\nThe maximum is: {1}", Minumum(arr), Maximum(arr));
            Console.WriteLine("The sum of the array is: {0} and the avarage of all numbers is: {1}", SumOfArr(arr), Avarage(arr));
            Console.WriteLine("The product is: {0}", ProductOfArr(arr));
        }

        static int Avarage(int[] arr)
        {
            return SumOfArr(arr) / arr.Length;
        }

        static int SumOfArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static int ProductOfArr(int[] arr)
        {
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }

        static int Maximum(int[] arr)
        {

            return MinOrMax(arr, -1);
        }

        static int Minumum(int[] arr)
        {
            return MinOrMax(arr, 1);
        }

        static int MinOrMax(int[] arr, int sign)
        {
            int highest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] * sign < highest * sign || i == 0)
                {
                    highest = arr[i];
                }
            }
            return highest;
        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

        private static int[] GetArray()
        {
            Console.WriteLine("Enter a set of integers on a single line: ");
            do
            {
                try
                {
                    string line = Console.ReadLine();
                    string[] numbers = line.Split();
                    List<int> list = new List<int>();
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] != "")
                        {
                            list.Add(int.Parse(numbers[i]));
                        }
                    }
                    int[] arr = list.ToArray();
                    return arr;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You have entered something that isn't an integer number! Try again!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You have entered integer either too big or too small! Try again!");
                }
            }
            while (true);
        }
    }
}
