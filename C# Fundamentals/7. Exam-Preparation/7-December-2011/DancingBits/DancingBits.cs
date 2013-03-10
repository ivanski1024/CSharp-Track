using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DancingBits
{
    class DancingBits
    {
        static void Main()
        {
            bool endOfGroup = false;
            int groupsCount = 0;
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string boofString;
            int boofNumber;
            StringBuilder finalString = new StringBuilder(""); //My String of 0 and 1
            // initializing the string value
            for (int i = 0; i < n; i++)
            {
                boofNumber = int.Parse(Console.ReadLine());
                boofString = Convert.ToString(boofNumber, 2);
                finalString.Append(boofString);
            }

            int stringLength = finalString.Length;
            int j = 0, p = 0;

            //Finding the count of groups with k same elements
            while (j < stringLength)
            {
                p = 0;
                while (!endOfGroup)
                {
                    if (finalString[j + p] != finalString[j])
                    {
                        j += p;
                        endOfGroup = true;
                    }
                    else
                    {
                        p++;
                        if (j + p == stringLength)
                        {
                            j += p;
                            endOfGroup = true;

                        }
                    }
                }
                if (k == p) groupsCount++;
                endOfGroup = false;
            }
            Console.WriteLine(groupsCount);
        }
    }
}
