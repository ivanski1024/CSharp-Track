using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSymbol
{
    class AddSymbol
    {
        static void Main()
        {
            Console.WriteLine("Enter a string no longer than 20 characters: ");
            string text = Console.ReadLine();
            String stars = new String('*', (20 - text.Length));
            text += stars;
            Console.WriteLine(text);
        }
    }
}
