using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slides
{
    class Slides
    {
        static void Main()
        {
            string line = Console.ReadLine();
            string[] strD = line.Split(' ');
            int w = int.Parse(strD[0]);
            int h = int.Parse(strD[1]);
            int d = int.Parse(strD[2]);
            string[, ,] cuboid = new string[h, d, w];
            string[] rowSeperator = { " | " };
            string[] elSeperators = { "(", ")" };
            for (int cLevel = 0; cLevel < h; cLevel++)
            {
                string currLevel = Console.ReadLine();
                string[] currRow = currLevel.Split(rowSeperator, StringSplitOptions.RemoveEmptyEntries);
                for (int cRow = 0; cRow < d; cRow++)
                {
                    string[] currEl = currRow[cRow].Split(elSeperators, StringSplitOptions.RemoveEmptyEntries);
                    for (int cElement = 0; cElement < w; cElement++)
                    {
                        cuboid[cLevel, cRow, cElement] = currEl[cElement];
                    }
                }
            }
            line = Console.ReadLine();
            strD = line.Split(' ');
            int level = 0;
            int row = int.Parse(strD[1]);
            int element = int.Parse(strD[0]);

            while (true)
            {
                int nextLevel = 0, nextRow = 0, nextElement = 0;
                Slide(cuboid, level, row, element, ref nextLevel, ref nextRow, ref nextElement);
                if (nextLevel == h)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("{0} {1} {2}", element, level, row);
                    break;
                }
                else if ((level == nextLevel && row == nextRow && element == nextElement) ||
                        ((nextRow < 0 || nextRow >= d) || (nextElement < 0 || nextElement >= w)))
                {
                    Console.WriteLine("No");
                    Console.WriteLine("{0} {1} {2}", element, level, row);
                    break;
                }
                level = nextLevel;
                row = nextRow;
                element = nextElement;

            }
        }

        static void Slide(string[, ,] cuboid, int level, int row, int element, ref int nextLevel, ref int nextRow, ref int nextElement)
        {
            string[] cube = cuboid[level, row, element].Split(' ');
            switch (cube[0])
            {
                case "B":
                    nextLevel = level;
                    nextRow = row;
                    nextElement = element;
                    break;
                case "E":
                    nextLevel = level + 1;
                    nextRow = row;
                    nextElement = element;
                    break;
                case "T":
                    nextLevel = level;
                    nextRow = int.Parse(cube[2]);
                    nextElement = int.Parse(cube[1]);
                    break;
                case "S":
                    switch (cube[1])
                    {
                        case "F":
                            nextLevel = level     + 1;
                            nextRow = row         - 1;
                            nextElement = element + 0;
                            break;
                        case "FR":
                            nextLevel = level     + 1;
                            nextRow = row         - 1; 
                            nextElement = element + 1; 
                            break;
                        case "R":
                            nextLevel = level     + 1;
                            nextRow = row         - 0;
                            nextElement = element + 1;
                            break;
                        case "BR":
                            nextLevel = level     + 1;
                            nextRow = row         + 1;
                            nextElement = element + 1;
                            break;
                        case "B":
                            nextLevel = level     + 1;
                            nextRow = row         + 1;
                            nextElement = element + 0;
                            break;
                        case "BL":
                            nextLevel = level     + 1;
                            nextRow = row         + 1;
                            nextElement = element - 1;
                            break;
                        case "L":
                            nextLevel = level     + 1;
                            nextRow = row         - 0;
                            nextElement = element - 1;
                            break;
                        case "FL":
                            nextLevel = level     + 1;
                            nextRow = row         - 1;
                            nextElement = element - 1;
                            break;
                    }
                    break;
            }
        }
    }
}
