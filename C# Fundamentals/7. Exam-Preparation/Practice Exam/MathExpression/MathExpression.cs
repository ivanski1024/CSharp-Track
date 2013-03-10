using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExpression;
using System.Threading;
using System.Globalization;

namespace MathExpression
{
    class MathExpression
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string N = Console.ReadLine();
            string M = Console.ReadLine();
            string P = Console.ReadLine();

            decimal n = decimal.Parse(N);
            decimal m = decimal.Parse(M);
            decimal p = decimal.Parse(P);

            double angle = Convert.ToDouble(m % 180);

            decimal func = (n * n + 1 / (m * p) + 1337) / (n - 128.523123123m * p) + Convert.ToDecimal( Math.Sin( ( angle ) ) );
            Console.WriteLine("{0:0.######}", func);
        }
    }
}
