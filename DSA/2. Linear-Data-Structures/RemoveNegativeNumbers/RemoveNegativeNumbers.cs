using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeNumbers
{
    class RemoveNegativeNumbers
    {
        static void Main(string[] args)
        {
            LinkedList<decimal> list = new LinkedList<decimal>();
            for (int index = -5; index < 5; index++)
            {
                list.AddLast(index);
            }

            Remove(list);

            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine(list.ElementAt<decimal>(index));
            }
        }

        public static void Remove(LinkedList<decimal> list)
        {
            for (int index = 0; index < list.Count; index++)
            {
                decimal element = list.ElementAt<decimal>(index);
                if (element < 0)
                {
                    list.Remove(element);
                    index--;
                }
            }
        }
    }
}
