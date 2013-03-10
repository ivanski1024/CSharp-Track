using System;
class isPrime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = (( n % 2 == 0) && ( n % 3 == 0) && ( n % 5 == 0) && ( n % 7 == 0)) ||
                        ( n == 2 ) || ( n == 3 ) || ( n == 5 ) || ( n == 7 );
        Console.WriteLine(isPrime);
    }
}
