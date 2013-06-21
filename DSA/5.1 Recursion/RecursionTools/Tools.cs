namespace RecursionTools
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Tools
    {
        public static List<T> CopyList<T>(List<T> list)
        {
            List<T> copy = new List<T>();
            for (int index = 0; index < list.Count; index++)
            {
                copy.Add(list[index]);
            }
            return copy;
        }

        public static string Visualize<T>(List<List<T>> collections)
        {
            StringBuilder result = new StringBuilder();
            for (int colIndex = 0; colIndex < collections.Count; colIndex++)
            {
                for (int elIndex = 0; elIndex < collections[colIndex].Count; elIndex++)
                {
                    result.AppendFormat("{0} ", collections[colIndex][elIndex]);
                }
                result.AppendLine();
            }

            return result.ToString();
        }

        public static void Main() { }
    }
}
