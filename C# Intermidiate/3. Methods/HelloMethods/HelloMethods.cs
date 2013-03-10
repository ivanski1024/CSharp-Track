using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMethods
{
    class HelloMethods
    {

        static void Main()
        {
            Hello();
        }
        static void Hello()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
