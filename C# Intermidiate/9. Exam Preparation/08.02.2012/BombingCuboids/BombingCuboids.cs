using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombingCuboids
{
    class BombingCuboids
    {
        static char[, ,] cuboid;
        static int[] bombed = new int[26];
        static int totalHit;
        static int width, height, depth;
        static void Main()
        {
            GetCuboid();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Bomb();
                FallDown();
            }
            Console.WriteLine(totalHit);
            for (int i = 0; i < 26; i++)
            {
                if (bombed[i] != 0)
                {
                    Console.WriteLine("{0} {1}", (char)(i+'A'), bombed[i]);
                }
            }
        }

        private static void FallDown()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < depth; j++)
                {
                    FallDownColumn(i, j);
                }
            }
        }
        private static void FallDownColumn(int w, int d)
        {
            int bottom = 0;
            for (int curr = 0; curr < height; curr++)
            {
                if (cuboid[w, curr, d] != ' ')
                {
                    if (bottom != curr)
                    {
                        cuboid[w, bottom, d] = cuboid[w, curr, d];
                        cuboid[w, curr, d] = ' ';
                    }
                    bottom++;
                }
            }
        }
        private static void PrintCuboid()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < depth; j++)
                {
                    for (int k = 0; k < width; k++)
                    {
                        Console.Write(cuboid[k, i, j]);
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private static void Bomb()
        {
            string line = Console.ReadLine();
            string[] c = line.Split(' ');
            Detonate(int.Parse(c[0]), int.Parse(c[1]), int.Parse(c[2]), int.Parse(c[3]));
        }

        private static void Detonate(int w, int h, int d, int p)
        {
            for (int i = w - p; i <= w + p; i++)
            {
                for (int j = h-p; j <= h+p; j++)
                {
                    for (int k = d-p; k <= d+p; k++)
                    {
                        if (i >= 0 && i < width &&
                            j >= 0 && j < height &&
                            k >= 0 && k < depth)
                        {
                            if (cuboid[i, j, k] != ' ')
                            {
                                if (p * p >= ((w - i) * (w - i) + (h - j) * (h - j) + (d - k) * (d - k)))
                                {
                                    bombed[cuboid[i, j, k] - 'A']++;
                                    totalHit++;
                                    cuboid[i, j, k] = ' ';
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void GetCuboid()
        {
            string line = Console.ReadLine();
            string[] n = line.Split(' ');
            width = int.Parse(n[0]);
            height = int.Parse(n[1]);
            depth = int.Parse(n[2]);
            cuboid = new char[width, height, depth];
            for (int j = 0; j < height; j++)
            {
                line = Console.ReadLine();
                n = line.Split(' ');
                for (int k = 0; k < depth; k++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        cuboid[i, j, k] = n[k][i];
                    }
                }
            }
        }
    }
}
