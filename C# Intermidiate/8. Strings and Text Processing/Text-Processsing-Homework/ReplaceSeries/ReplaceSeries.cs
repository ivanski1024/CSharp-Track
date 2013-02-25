using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSeries
{
    class ReplaceSeries
    {
        static void Main()
        {
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();
            StringBuilder mod = new StringBuilder();
            mod.Append(text[0]);
            for (int i = 1; i < text.Length-1; i++)
            {
                if (text[i] != text[i - 1])
                {
                    mod.Append(text[i]);
                }
            }
            Console.WriteLine(mod);
        }
    }
}
