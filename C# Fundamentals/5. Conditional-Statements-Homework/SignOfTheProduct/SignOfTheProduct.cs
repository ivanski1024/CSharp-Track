using System;
class SignOfTheProduct
{
    static void Main()
    {
        double a, b, c;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());
        if( (a>0 && b>0 && c>0) || (a<0 && b<0 && c>0) || (a<0 && b>0 && c<0) || (a>0 && b<0 && c<0))
        {
            Console.WriteLine("The sign of the product of your numbers is +");
        }
        else if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0))
        {
            Console.WriteLine("The sign of the product of your numbers is -");
        }
        else
        {
            Console.WriteLine("One of your numbers is 0");
        }
    }
}
