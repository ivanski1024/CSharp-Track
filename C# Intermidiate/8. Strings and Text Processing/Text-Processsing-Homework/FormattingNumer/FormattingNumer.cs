using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumer
{
    class FormattingNumer
    {
        static void Main()
        {
            int n;
            while (true)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a valid decimal number! Try again:");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("You entered \"null\". To exit Ctrl+C");
                }
            }
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Your number in:\n");
            output.AppendFormat(" - decimal representation: {0}\n", n.ToString("D"));
            output.AppendFormat(" - hexadecimal representation: {0}\n", n.ToString("X"));
            output.AppendFormat(" - percentige: {0}\n", n.ToString("P"));
            output.AppendFormat(" - scientific notation: {0}\n", n.ToString("E"));
            Console.WriteLine(output);
        }
    }
}
