using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {

        static int width, height;

        static int Main()
        {
            
            InitialSettings(height, width);
            RunCalc();
            
            return 0;
        }

        static void RunCalc()
        {
            HomeScreen();
            MakeDecision(GetDecision());
        }

        static void LinearEquasion()
        {
            bool valid = false, first = true;
            int x = width / 2 - 15, y= height/2;
            double a=0, b=0;
            do
            {
                Console.Clear();
                if (!first)
                {
                    Console.SetCursorPosition(x, y - 2);
                    Console.WriteLine("Invalid input. Try again: ( a != 0)");
                }
                Console.SetCursorPosition(x, y - 1);
                Console.WriteLine("ax + b = 0");
                Console.SetCursorPosition(x, y);
                Console.Write("a = ");
                string astr = Console.ReadLine();
                Console.SetCursorPosition(x, y + 1);
                Console.Write("b = ");
                string bstr = Console.ReadLine();
                if( double.TryParse(astr, out a) && double.TryParse(bstr, out b))
                {
                    valid = true;
                }
                first=false;
            } 
            while (!valid);
            Console.Clear();
            Console.SetCursorPosition(x, y - 1);
            Console.WriteLine("{0}x + {1} = 0", a, b);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Root x = {0:0.###}", (-b/a));
            Console.SetCursorPosition(x, y+1);
            ReturnToMenu(x, y + 1);
        }

        static void Avarage()
        {
            int x = width / 2 - 25, y = height / 2;
            Console.Clear();
            Console.CursorVisible = true;
            Console.SetCursorPosition(x, y);
            int n, count = 0;
            double sum = 0;
            bool valid = false, first = true, seenNumber = false;
            do
            {
                if (!first)
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y - 2);
                    Console.WriteLine("Input isn't valid. Try again: ");
                }
                Console.SetCursorPosition(x, y - 1);
                Console.WriteLine("Enter the numbers (each one seperated with ' ':");
                Console.SetCursorPosition(x, y);
                string input = Console.ReadLine();
                string[] numbers = input.Split(' ');
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] != "")
                    {
                        if (int.TryParse(numbers[i], out n))
                        {
                            seenNumber = true;
                            count++;
                            sum += n;
                        }
                        else
                        {
                            seenNumber = false;
                            valid = false;
                            break;
                        }
                    }
                }
                if (seenNumber)
                {
                    valid = true;
                }
                first = false;
            }
            while (!valid);
            Console.Clear();
            Console.SetCursorPosition(x, y-1);
            Console.WriteLine("The avarage of the {0} integers you entered is: {1:0.###}", count, sum / count);
            Console.CursorVisible = false;
            ReturnToMenu(x, y);
        }

        static void ReverseInteger()
        {
            int x = width / 2 - 25, y = height / 2;
            Console.Clear();
            int n=0, number ;
            bool valid = false, first = true;
            do
            {
                try
                {
                    Console.SetCursorPosition(x, y - 1);
                    Console.WriteLine("Enter an integer number");
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("(number should be non-negative): ");
                    Console.SetCursorPosition(x, y + 1);
                    n = int.Parse(Console.ReadLine());
                    first = false;
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y - 2);
                    Console.Write("The number you entered is too big or too small for Int32. Please try again: ");
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y - 2);
                    Console.Write("Your input isn't a number. Please try again: ");
                }
            }
            while (!valid);
            number = n;
            int reversed = 0;
            while (n > 0)
            {
                reversed *= 10;
                reversed += n % 10;
                n /= 10;
            }
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("The Reversed Integer of {0} is: {1}", number, reversed);
            ReturnToMenu(x, y + 1);
        }

        static void ReturnToMenu(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Go back to the menu? (Y or N)");
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    if (input.Key == ConsoleKey.Y)
                    {
                        RunCalc();
                        return;
                    }
                    else if (input.Key == ConsoleKey.N)
                    {
                        return;
                    }
                }
            }
        }

        static void MakeDecision(int decision)
        {
            switch (decision)
            {
                case 1:
                    ReverseInteger();
                    break;
                case 2:
                    Avarage();
                    break;
                case 3:
                    LinearEquasion();
                    break;
                case 4:
                    return;
                    break;
            }
        }

        static int GetDecision()
        {
            int desicion = 0;
            while (true)
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    if (input.Key == ConsoleKey.D1 || (input.Key == ConsoleKey.NumPad1))
                    {
                        return 1;
                    }
                    else if (input.Key == ConsoleKey.D2 || (input.Key == ConsoleKey.NumPad2))
                    {
                        return 2;
                    }

                    else if (input.Key == ConsoleKey.D3 || (input.Key == ConsoleKey.NumPad3))
                    {
                        return 3;
                    }

                    else if (input.Key == ConsoleKey.D4 || (input.Key == ConsoleKey.NumPad4))
                    {
                        return 4;
                    }
                    else
                    {
                        Console.Clear();
                        HomeScreen();
                    }
                }
            }
            return desicion;
        }

        static void InitialSettings(int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
            width = Console.WindowWidth;
            height = Console.WindowHeight;

        }

        static void HomeScreen()
        {
            Console.Clear();
            string[] heading = 
            {
                "Calculator v1.0",
                "by IAP",
                ""
            };

            string[] menu = 
            { 
                "Menu:",
                "1. Reversing integer",
                "2. Avarege of integers",
                "3. Solve a linear equation (a*x + b = 0)",
                "4. Exit\n",
                "Please choose option (1, 2, 3 or 4): "
            };
            for (int i = 0; i < heading.Length; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - heading[i].Length) / 2, (Console.WindowHeight / 2 - heading.Length + i));
                Console.WriteLine(heading[i]);
            }
            int width = (Console.WindowWidth - menu[3].Length) / 2;
            for (int i = 0; i < menu.Length; i++)
            {
                Console.SetCursorPosition(width, Console.WindowHeight / 2 + i - 1);
                Console.Write(menu[i]);
            }
        }
    }
}