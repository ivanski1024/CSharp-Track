using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaBit1
{
    class FormulaBit1
    {
        public struct position
        {
            public int x, y;
            public position(int cX, int cY)
            {
                this.x = cX;
                this.y = cY;
            }
        }
        static readonly position[] dir = new position[4] 
    { 
        new position(0, 1), 
        new position(1, 0),
        new position(0, -1), 
        new position(1, 0) 
    };
        static void Main(string[] args)
        {
            bool[,] grid = new bool[8, 8];
            byte n;

            for (int i = 0; i < 8; i++)
            {
                n = byte.Parse(Console.ReadLine());
                for (int j = 0; j < 8; j++)
                {

                    grid[j, i] = ((n & (1 << j)) >> j == 1);
                }

            }
            position pos = new position(0, 0);
            int d = 0;
            int track = 1;
            bool end = false, stop = false, justturned = false;
            int turns = 0;

            while (!stop)
            {
                if (pos.x == 0 && pos.y == 0 && grid[0, 0] == true)
                {
                    stop = true;
                    track = 0;
                    break;
                }
                if (pos.x == 7 && pos.y == 7)
                {
                    stop = true;
                    end = true;
                    break;
                }
                if (((pos.x + dir[d].x) >= 0) && ((pos.x + dir[d].x) < 8) && ((pos.y + dir[d].y) >= 0) && ((pos.y + dir[d].y) < 8))
                {
                    if (!grid[pos.x + dir[d].x, pos.y + dir[d].y])
                    {
                        pos.x += dir[d].x;
                        pos.y += dir[d].y;
                        track++;
                        justturned = false;
                    }
                    else if (justturned)
                    {
                        stop = true;
                    }
                    else
                    {
                        if (d == 3)
                        {
                            d = 0;
                        }
                        else
                            d++;
                        turns++;
                        justturned = true;
                    }
                }
                else if (justturned)
                {
                    stop = true;
                }
                else
                {
                    if (d == 3)
                    {
                        d = 0;
                    }
                    else
                    {
                        d++;
                    }
                    turns++;
                    justturned = true;
                }
            }
            if (!end)
            {
                Console.WriteLine("No {0}", track);
            }
            else
            {
                Console.WriteLine("{0} {1}", track, turns);
            }
        }
    }
}
