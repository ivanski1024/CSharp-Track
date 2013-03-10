using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentLetters
{
    class DifferentLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();
            int[] chars = new int[127];
            for (int i = 0; i < text.Length; i++)
            {
                chars[(int)text[i]]++;
            }
            for (int i = 0; i < 127; i++)
            {
                if (chars[i] != 0)
                {
                    Console.WriteLine("'{0}' - {1}", (char)i, chars[i]);
                }
            }
        }
    }
}
