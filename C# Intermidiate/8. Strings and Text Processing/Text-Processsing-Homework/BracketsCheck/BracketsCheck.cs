using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsCheck
{
    class BracketsCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter an expression: ");
            string expression = Console.ReadLine();
            int OpenBrackets = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    OpenBrackets++;
                }
                else if (expression[i] == ')')
                {
                    if (OpenBrackets > 0)
                    {
                        OpenBrackets--;
                    }
                    else
                    {
                        Console.WriteLine("The expression is incorrect!");
                        return;
                    }
                }
            }
            if (OpenBrackets == 0)
            {
                Console.WriteLine("The expression is correct!");
            }
            else 
            {
                Console.WriteLine("The expression is incorrect!");
            }
        }
    }
}