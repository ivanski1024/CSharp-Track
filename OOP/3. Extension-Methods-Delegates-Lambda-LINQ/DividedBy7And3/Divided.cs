using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedBy7And3
{
    public class Divided
    { 
        public static int[] DividedNumbers(int[] array)
        {
            List<int> list = array.ToList<int>();
            List<int> selected = list.FindAll(number => (number % 3 == 0) && (number % 7 == 0));
            return selected.ToArray();
        }

        public static int[] DividedNumbersLinq(int[] array)
        {
            var selected =
                from number in array
                where (number % 3 == 0) && (number % 7 == 0)
                select number;
            return selected.ToArray<int>();
        }
    }
}
