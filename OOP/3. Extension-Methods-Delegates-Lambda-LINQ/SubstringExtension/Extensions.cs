using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringExtension
{
    static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder subStr = new StringBuilder();
            for (int i = index; i < index+length; i++)
            {
                subStr.Append(str[i]);
            }
            return subStr;
        }
    }
}
