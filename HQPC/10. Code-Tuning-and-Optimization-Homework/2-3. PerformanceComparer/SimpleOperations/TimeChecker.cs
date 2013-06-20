using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOperations
{
    class TimeChecker
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(string.Format("{0,9}|{1,9}|{2,9}|{3,9}|{4,9}|{5,9}|", "Operation", "int", "long", "float", "double", "decimal"));
            output.AppendLine(string.Format("---------|---------|---------|---------|---------|---------|"));
            Stopwatch stopwatch = new Stopwatch();

            int intBoof = 0;
            long longBoof = 0;
            float floatBoof = 0;
            double doubleBoof = 0;
            decimal decimalBoof = 0;

            double intSpan, longSpan, floatSpan, doubleSpan, decimalSpan;

            #region Add
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                intBoof = 3 + 5;
            stopwatch.Stop();
            intSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                longBoof = 3L + 5L;
            stopwatch.Stop();
            longSpan = stopwatch.Elapsed.TotalMilliseconds - 0;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                floatBoof = 3f + 5f;
            stopwatch.Stop();
            floatSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                doubleBoof = 3d + 5d;
            stopwatch.Stop();
            doubleSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                decimalBoof = 3m + 5m;
            stopwatch.Stop();
            decimalSpan = stopwatch.Elapsed.TotalMilliseconds;

            output.AppendLine(string.Format("{0,9}|{1,9}|{2,9}|{3,9}|{4,9}|{5,9}|", "+", intSpan, longSpan, floatSpan, doubleSpan, decimalSpan));
            output.AppendLine(string.Format("---------|---------|---------|---------|---------|---------|"));
            #endregion

            #region Substract
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                intBoof = 3 - 5;
            stopwatch.Stop();
            intSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                longBoof = 3L - 5L;
            stopwatch.Stop();
            longSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                floatBoof = 3f - 5f;
            stopwatch.Stop();
            floatSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                doubleBoof = 3d - 5d;
            stopwatch.Stop();
            doubleSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                decimalBoof = 3m - 5m;
            stopwatch.Stop();
            decimalSpan = stopwatch.Elapsed.TotalMilliseconds;

            output.AppendLine(string.Format("{0,9}|{1,9}|{2,9}|{3,9}|{4,9}|{5,9}|", "-", intSpan, longSpan, floatSpan, doubleSpan, decimalSpan));
            output.AppendLine(string.Format("---------|---------|---------|---------|---------|---------|"));
            #endregion

            #region Increment

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                intBoof++;
            stopwatch.Stop();
            intSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                longBoof++;
            stopwatch.Stop();
            longSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                floatBoof++;
            stopwatch.Stop();
            floatSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                doubleBoof++;
            stopwatch.Stop();
            doubleSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                decimalBoof++;
            stopwatch.Stop();
            decimalSpan = stopwatch.Elapsed.TotalMilliseconds;

            output.AppendLine(string.Format("{0,9}|{1,9}|{2,9}|{3,9}|{4,9}|{5,9}|", "++", intSpan, longSpan, floatSpan, doubleSpan, decimalSpan));
            output.AppendLine(string.Format("---------|---------|---------|---------|---------|---------|"));
            #endregion

            #region Multiply

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                intBoof = 3 * 5;
            stopwatch.Stop();
            intSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                longBoof = 3L * 5L;
            stopwatch.Stop();
            longSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                floatBoof = 3f * 5f;
            stopwatch.Stop();
            floatSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                doubleBoof = 3d * 5d;
            stopwatch.Stop();
            doubleSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                decimalBoof = 3m * 5m;
            stopwatch.Stop();
            decimalSpan = stopwatch.Elapsed.TotalMilliseconds;

            output.AppendLine(string.Format("{0,9}|{1,9}|{2,9}|{3,9}|{4,9}|{5,9}|", "*", intSpan, longSpan, floatSpan, doubleSpan, decimalSpan));
            output.AppendLine(string.Format("---------|---------|---------|---------|---------|---------|"));
            #endregion

            #region Substract

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                intBoof = 3 / 5;
            stopwatch.Stop();
            intSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                longBoof = 3L / 5L;
            stopwatch.Stop();
            longSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                floatBoof = 3f / 5f;
            stopwatch.Stop();
            floatSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                doubleBoof = 3d / 5d;
            stopwatch.Stop();
            doubleSpan = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
                decimalBoof = 3m / 5m;
            stopwatch.Stop();
            decimalSpan = stopwatch.Elapsed.TotalMilliseconds;

            output.AppendLine(string.Format("{0,9}|{1,9}|{2,9}|{3,9}|{4,9}|{5,9}|", "/", intSpan, longSpan, floatSpan, doubleSpan, decimalSpan));
            output.AppendLine(string.Format("---------|---------|---------|---------|---------|---------|"));
            #endregion

            Console.WriteLine(output.ToString());

        }


    }
}
