using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromSBaseToDBase
{
    class FromSBaseToDBase
    {
        
        static void Main()
        {
            Console.WriteLine("Enter S base: ");
            int s=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number in base {0}: ", s);
            string Ns=Console.ReadLine();
            Console.WriteLine("Enter D base: ");
            int d = int.Parse(Console.ReadLine());

            int n=0, pos=Ns.Length-1;
            int powS = 1;
            for (int i = 0; i < Ns.Length; i++)
            {
                n += GetValue(Ns[pos - i]) * powS;
                powS *= s;
            }
            //Console.WriteLine(n);


            List<char> NdList = new List<char>();
            while (n > 0)
            {
                NdList.Insert(0, GetValue(n % d));
                n /= d;
            }

            foreach (char c in NdList)
            {
                Console.Write(c);
            }
            /*
            string Nd = NdList.ToString();
            Nd.Reverse();
            for (int i = 0; i < Nd.Length; i++)
            {
                Console.Write(Nd[i]);
            }

            */


        }
        static int GetValue(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return int.Parse(c.ToString());
            }
            else if (c >= 'A' && c <= 'Z')
            {
                return 10 + c - 'A';
            }
            else if (c >= 'a' && c <= 'z')
            {
                return 10 + c - 'a';
            }
            return 0;
        }
        static char GetValue(int n)
        {
            char c=' ';
            if (n / 10 == 0)
            {
                return (char)('0' + n);
            }
            else
            {
                return (char)('A' + n - 10);
            }
        }
    }
}
