using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Carpets
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int t = 0;
            if (n % 4 != 0)
                t = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < n / 2 && j < n / 2)
                    { 
                        if(i+j<n/2-1)
                            Console.Write('.');
                        else if ((i + j + t)%2==1)
                            Console.Write('/');
                        else
                            Console.Write(' ');
                    }
                    if (i < n / 2 && j >= n / 2)
                    {
                        if (n - 1 - j + i < n / 2 - 1)
                            Console.Write('.');
                        else if( (n - 1 - j + i + t) % 2 == 1)
                            Console.Write('\\');
                        else
                            Console.Write(' ');
                    }
                    if (i >= n / 2 && j < n / 2)
                    { 
                        if (n - 1 - i + j < n / 2 - 1)
                            Console.Write('.');
                        else if ((n - 1 - i + j + t) % 2 == 1)
                            Console.Write('\\');
                        else
                            Console.Write(' ');
                        
                    }
                    if (i >= n / 2 && j >= n / 2)
                    {
                        if ((n - 1 - i) + (n-1-j) < n / 2 - 1)
                            Console.Write('.');
                        else if( ( (n - 1 - i) + (n - 1 - j) + t )%2==1)
                            Console.Write('/');
                        else
                            Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
