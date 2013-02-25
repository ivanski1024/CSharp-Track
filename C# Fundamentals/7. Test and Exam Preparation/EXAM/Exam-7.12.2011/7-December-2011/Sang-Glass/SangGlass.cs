using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangGlass
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if( (j>=i && j+i<= n-1)||(j<=i && j+i>= n-1) )
                    {
                        Console.Write('*');
                    }
                    else
                        Console.Write('.');
                }
                Console.WriteLine();
            }
        }
    }
}
