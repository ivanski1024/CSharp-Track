using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenercList
{
    class GenercList_Main
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            a.Add("3");
            a.Add("4");
            a.Add("5");
            Console.WriteLine(a.Min<string>());
        }
    }
}
