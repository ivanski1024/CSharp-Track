using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2._1
{
    class Program
    {
        static void Main()
        {
            decimal[] arr = GetArray();
            Console.WriteLine("The minimum is: {0}\nThe maximum is: {1}", Minumum(arr), Maximum(arr));
            Console.WriteLine("The sum of the array is: {0} and the avarage of all numbers is: {1}", SumOfArr(arr), Avarage(arr));
            Console.WriteLine("The product is: {0}", ProductOfArr(arr));
        }

        static T Avarage<T>(T[] arr)
        {
            return SumOfArr(arr) / (dynamic)arr.Length;
        }

        static T SumOfArr<T>(T[] arr)
        {
            dynamic sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static T ProductOfArr<T>(T[] arr)
        {
            dynamic product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }

        static T Maximum<T>(T[] arr)
        {

            return MinOrMax(arr, (dynamic)(-1));
        }

        static T Minumum<T>(T[] arr)
        {
            return MinOrMax(arr, (dynamic)1);
        }

        static T MinOrMax<T>(T[] arr, dynamic sign)
        {
            dynamic highest = 0;
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

        static decimal[] GetArray()
        {
            Console.WriteLine("Enter a set of integers on a single line: ");
            do
            {
                try
                {
                    string line = Console.ReadLine();
                    string[] numbers = line.Split();
                    List<decimal> list = new List<decimal>();
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] != "")
                        {
                            list.Add(decimal.Parse(numbers[i]));
                        }
                    }
                    decimal[] arr = list.ToArray();
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
