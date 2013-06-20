using System;
using System.Linq;

namespace StatisticsPrinter
{
    class StatisticsPrinter
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double max = 0;
            for (int element = 0; element < count; element++)
            {
                if (arr[element] > max)
                {
                    max = arr[element];
                }
            }

            PrintMax(max);

            double min = 0;
            for (int element = 0; element < count; element++)
            {
                if (arr[element] < min)
                {
                    min = arr[element];
                }
            }

            PrintMin(min);

            double sum = 0;
            for (int element = 0; element < count; element++)
            {
                sum += arr[element];
            }

            PrintAverage(sum / count);
        }

        public void PrintMax(double max)
        {
            Console.WriteLine(max);
        }
        public void PrintMin(double min)
        {
            Console.WriteLine(min);
        }
        public void PrintAverage(double average)
        {
            Console.WriteLine(average);
        }

    }
}
