using System;
using System.Linq;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int l = s.Length;
            char[] chars = new char[l];
            for (int i = 0; i <= l / 2; i++)
            {
                chars[i] = s[l - i - 1];
                chars[l - 1 - i] = s[i];
            }
            chars.ToString();
            Console.WriteLine(chars);
        }
    }
}