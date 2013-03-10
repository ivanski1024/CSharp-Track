using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomeDecoder
{
    class GenomeDecoder
    {
        static void Main()
        {
            string[] separators = { " " };
            string[] data = (Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries));
            int N = int.Parse(data[0]);
            int M = int.Parse(data[1]);
            string encoded = Console.ReadLine();
            string decoded = Decoder(encoded);
            Print(N, M, decoded);
        }

        private static void Print(int n, int m, string decoded)
        {
            int linesCount = decoded.Length / n + ( decoded.Length % n == 0 ? 0 : 1 );
            int noLength = linesCount.ToString().Length;

            for (int line = 1; line <= linesCount; line++)
            {
                for (int i = 0; i < (noLength - line.ToString().Length); i++)
                {
                    Console.Write(" ");
                }
                Console.Write("{0} ", line);
                if (line <= decoded.Length/n)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (i != 0 && i % m == 0)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(decoded[(line-1) * n + i]);
                    }
                }
                else
                {
                    //Console.WriteLine(decoded.Length%n);
                    for (int i = 0; i < decoded.Length % n; i++)
                    {
                        if (i != 0 && i % m == 0)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(decoded[(line-1) * n + i]);
                    }
                }
                Console.WriteLine();
            }
        }

        private static string Decoder(string encoded)
        {
            int i = 0;
            int count = 0;
            StringBuilder decoded = new StringBuilder();
            while (i < encoded.Length)
            {
                count = 0;
                while (encoded[i] >= '0' && encoded[i] <= '9')
                {
                    count *= 10;
                    count += (encoded[i] - '0');
                    i++;
                }
                if (count == 0)
                {
                    count = 1;
                }
                for (int j = 0; j < count; j++)
                {
                    decoded.Append(encoded[i]);
                }
                i++;
            }
            return decoded.ToString();
        }
    }
}
