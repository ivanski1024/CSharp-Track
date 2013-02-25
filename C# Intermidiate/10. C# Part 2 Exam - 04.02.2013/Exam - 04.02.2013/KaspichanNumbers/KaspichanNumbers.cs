using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            short currDigit;
            StringBuilder kaspichan = new StringBuilder();
            if (n == 0)
            {
                Console.WriteLine("A");
            }
            while (n > 0)
            {
                currDigit = (short)(n % 256);
                kaspichan.Insert(0, (char)('A' + currDigit % 26));
                if (currDigit / 26 > 0)
                {
                    kaspichan.Insert(0, (char)('a' + currDigit / 26 - 1));
                }
                n /= 256;
            }
            Console.WriteLine(kaspichan); 
        }
    }
}
