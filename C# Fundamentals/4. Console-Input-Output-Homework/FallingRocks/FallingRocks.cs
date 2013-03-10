using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FallingRocks
{
    public class element
    {
        public int positionX, positionY, width;
        public ConsoleColor color;
        public string body;
        public element(int x, int y, int w, string el, ConsoleColor col)            // Element Constructor that sets
        {
            this.positionX = x; this.positionY = y;                                 // X and Y position
            this.width = w;                                                         // Width
            this.body = el;                                                         // String that is the body of the element
            this.color = col;                                                       // Color
        }
        public void Draw()                                                          // Method that draws an object on its position
        {
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(positionX + i, positionY);
                Console.ForegroundColor = color;
                Console.Write(body[i]);
            }
        }
        public void eraseLastElements()                                             // Method that clears the last position of the element
        {
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(positionX + i, positionY);
                Console.Write(" ");
            }
        }
    }
    class FallingRocks
    {
        static void setWindowSize(int x, int y)
        {
            Console.SetWindowSize(x, y);
            Console.SetBufferSize(x, y);
        }
        static void GameOver(int score)
        {
            Console.Clear();
            Console.SetCursorPosition((Console.BufferWidth / 2 - 10), Console.BufferHeight / 2 - 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("GAME OVER!");
            Console.SetCursorPosition(Console.BufferWidth / 2 - 10, Console.BufferHeight / 2);
            Console.WriteLine("Your score is: {0} Points", (score - Console.BufferHeight - 1 ) * 10);
            Console.SetCursorPosition(Console.BufferWidth / 2 - 10, Console.BufferHeight / 2 + 1 );
        }
        static void Main(string[] args)
        {
            char[] elements = { '^', '@', '*', '&', '+', '%', '#', '!', '.', ';', '-' };
            ConsoleColor[] colors = { ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Magenta };

            int Score = 0;
                                                                                    // Console Settings
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false;

                                                                                    // Units in the game
            element dwarf = new element((Console.WindowWidth / 2 - 1), (Console.WindowHeight - 2), 3, "(*)", colors[3]);
            List<element> rocks = new List<element>();

            Random randomGen = new Random();
            int elementsOnLine;
            dwarf.Draw();
            while (true)
            {
                dwarf.Draw();
                for (int i = 0; i < 5; i++)
                {
                    if (Console.KeyAvailable)                                       // Get key and move dwarf (available 5 times in 1 move of the rocks)
                    {
                        ConsoleKeyInfo input = Console.ReadKey();
                        if (input.Key == ConsoleKey.LeftArrow && dwarf.positionX != 0)
                        {
                            dwarf.eraseLastElements();
                            dwarf.positionX--;
                            dwarf.Draw();
                        }
                        if (input.Key == ConsoleKey.RightArrow && dwarf.positionX != Console.WindowWidth - 3)
                        {
                            dwarf.eraseLastElements();
                            dwarf.positionX++;
                            dwarf.Draw();
                        }
                    }
                    if (Console.KeyAvailable) Console.ReadKey();                    // Clearing the boofer
                }
                for (int i = 0; i < rocks.Count; i++)
                {
                    rocks[i].eraseLastElements();                                   // Clearing the space on the last position of every rock
                    rocks[i].positionY++;
                    if ((rocks[i].positionY == dwarf.positionY) &&                  //
                        !((rocks[i].positionX >= dwarf.positionX + dwarf.width) ||  // Collision detector
                        (rocks[i].positionX + rocks[i].width <= dwarf.positionX)))  //
                    {
                        GameOver(Score);
                        return;
                    }
                }
                for (int i = 0; i < rocks.Count; i++)
                {
                    if (rocks[i].positionY >= Console.BufferHeight - 2)
                    {
                        rocks.RemoveAt(i);                                          // Remove Rocks that are on the last line
                    }
                }
                                                                                    // Add new Rocks
                elementsOnLine = randomGen.Next(1, 5);                              // Sets how much can be the rocks on every line
                for (int i = 0; i < elementsOnLine; i++)
                {
                    int wdt = randomGen.Next(1, 4);
                    int x = randomGen.Next(0, Console.WindowWidth - wdt - 1);
                    int el = randomGen.Next(0, 5);
                    int y = 0;
                    ConsoleColor col = colors[randomGen.Next(0, 3)];
                    StringBuilder currBody = new StringBuilder("");
                    for (int j = 0; j < wdt; j++)
                    {
                        currBody.Append(elements[el]);
                    }
                    element currElement = new element(x, y, wdt, Convert.ToString(currBody), col);
                    rocks.Add(currElement);
                }
                foreach (element curr in rocks)
                {
                    curr.Draw();                                                    // Draw current Rocks
                }
                Score++;
                Thread.Sleep(150);
            }
        }
    }
}