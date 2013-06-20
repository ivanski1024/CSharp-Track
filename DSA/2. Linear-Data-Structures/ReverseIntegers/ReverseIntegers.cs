using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseIntegers
{
    class ReverseIntegers
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());

            for (int index = 0; index < N; index++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }

            for (int index = 0; index < N; index++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
