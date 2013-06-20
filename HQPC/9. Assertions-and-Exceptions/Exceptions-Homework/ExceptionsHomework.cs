using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (startIndex < 0 || arr.Length <= startIndex)
        {
            throw new IndexOutOfRangeException("startIndex is out of the arrays limits!");
        }
        else if (count < 0)
        {
            throw new ArgumentException("Count can't be negative number!");
        }
        else if (startIndex + count > arr.Length)
        {
            throw new ArgumentException("The subsequnce goes out ot the arrays limits!");
        }
        else
        {
            List<T> result = new List<T>();
            for (int index = startIndex; index < startIndex + count; index++)
            {
                result.Add(arr[index]);
            }
            return result.ToArray();
        }
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("Count can't be bigger than the strings length!");
        }
        else
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }
            return result.ToString();
        }
    }

    public static bool CheckPrime(int number)
    {
        if (number < 2)
        {
            throw new ArgumentOutOfRangeException("The number should be at least 2 to check if it's prime!");
        }
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        //Console.WriteLine(ExtractEnding("Hi", 100));

        if (CheckPrime(23))
        {
            Console.WriteLine("23 is prime.");
        }
        else
        {
            Console.WriteLine("23 is not prime");
        }

        if (CheckPrime(33))
        {
            Console.WriteLine("33 is prime.");
        }
        else
        {
            Console.WriteLine("33 is not prime");
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2, 3),
            new CSharpExam(55, 100),
            new CSharpExam(100, 100),
            new SimpleMathExam(1, 3),
            new CSharpExam(0, 100),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
