using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringExtension
{
    class SubstringExtension
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Goshko e pich!");
            StringBuilder subStr = str.Substring(0, 6);
            Console.WriteLine(subStr);
        }
    }
}
