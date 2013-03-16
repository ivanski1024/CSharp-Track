using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTaskIsNotEnough
{
    class OneTaskIsNotEnough
    {
        static void Main()
        {
            Console.WriteLine("{0}\n{1}", Lamps(int.Parse(Console.ReadLine())), JoroTheBot((Console.ReadLine()).ToCharArray(), Console.ReadLine().ToCharArray()));
            //Console.WriteLine("{0}", Lamps(int.Parse(Console.ReadLine())));
        }

        static StringBuilder JoroTheBot(char[] path12, char[] path22)
        {
            int l = path12.Length * path22.Length / GCD(path12.Length, path22.Length);
            StringBuilder path1 = new StringBuilder();
            StringBuilder path2 = new StringBuilder();
            if (path12.Length < path22.Length)
            {
                int i, j;
                for (i = 0; i < l / path22.Length; i++)
                {
                    path1.Append(path12);
                    path2.Append(path22);
                }
                for (j = i; j < l / path12.Length; j++)
                {
                    path1.Append(path12);
                }
            }
            else
            {
                int i, j;
                for (i = 0; i < l / path12.Length; i++)
                {
                    path1.Append(path12);
                    path2.Append(path22);
                }
                for (j = i; j < l / path22.Length; j++)
                {
                    path2.Append(path22);
                }
            }
            string bound1 = "unbounded\n", bound2 = "unbounded\n";
            bool boolbound1 = false, boolbound2 = false;
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            int dirx1 = 1, diry1 = 0, dirx2 = 1, diry2 = 0;
            for (int k = 0; k < 4; k++)
            {
                for (int i = 0; i < path1.Length; i++)
                {
                    switch (path1[i])
                    {
                        case 'L':
                            switch (dirx1)
                            {
                                case 0:
                                    diry1 *= 0;
                                    dirx1 = 1;
                                    break;
                                case 1:
                                    dirx1 = 0;
                                    diry1 = -1;
                                    break;
                                case -1:
                                    dirx1 = 0;
                                    diry1 = 1;
                                    break;
                            }
                            break;
                        case 'R':
                            switch (dirx1)
                            {
                                case 0:
                                    diry1 *= 0;
                                    dirx1 = -1;
                                    break;
                                case 1:
                                    dirx1 = 0;
                                    diry1 = 1;
                                    break;
                                case -1:
                                    dirx1 = 0;
                                    diry1 = -1;
                                    break;
                            }
                            break;
                        case 'S':

                            x1 += dirx1;
                            y1 += diry1;
                            break;
                    }
                    switch (path2[i])
                    {
                        case 'L':
                            switch (dirx2)
                            {
                                case 0:
                                    diry2 *= 0;
                                    dirx2 = 1;
                                    break;
                                case 1:
                                    dirx2 = 0;
                                    diry2 = -1;
                                    break;
                                case -1:
                                    dirx2 = 0;
                                    diry2 = 1;
                                    break;
                            }
                            break;
                        case 'R':
                            switch (dirx2)
                            {
                                case 0:
                                    diry2 *= 0;
                                    dirx2 = -1;
                                    break;
                                case 1:
                                    dirx2 = 0;
                                    diry2 = 1;
                                    break;
                                case -1:
                                    dirx2 = 0;
                                    diry2 = -1;
                                    break;
                            }
                            break;
                        case 'S':

                            x2 += dirx2;
                            y2 += diry2;
                            break;
                    }

                    if (x1 == 0 && y1 == 0)
                    {
                        bound1 = "bounded\n";
                        boolbound1 = true;
                    }

                    if (x2 == 0 && y2 == 0)
                    {
                        bound2 = "bounded\n";
                        boolbound2 = true;
                    }
                    if (boolbound1 && boolbound2)
                    {
                        break;
                    }
                }
                if (boolbound1 && boolbound2)
                {
                    break;
                }
            }
            StringBuilder output = new StringBuilder();
            output.Append(bound1);
            output.Append(bound2);
            return output;
        }
        static int Lamps(int n)
        {
            LinkedList<int> lamps = new LinkedList<int>();
            for (int i = 0; i < n; i++)
            {
                lamps.AddLast(i + 1);
                //lamps.Add
            }
            int during = 2;
            while (lamps.Count > 1)
            {
                for (int i = 0; i < lamps.Count; i+=during)
                {
                    lamps.Remove(lamps.ElementAt<int>(i)) ;
                    i--;
                }
                during++;
            }
            return lamps.ElementAt<int>(0);



            /*

            bool enter = false;
            while (lamps.Count > 1)
            {
                enter = false;
                LinkedList<int> turnedOn = new LinkedList<int>();
                
                int l = 0;
                for (int i = 0; i < lamps.Count; i++)
                {
                    if (!enter)
                    {
                        if (lamps[i] != turnedOn[l])
                        {
                            newLamps.Add(lamps[i]);
                        }
                        else
                        {
                            l++;
                            if (l >= turnedOn.Count)
                            {
                                enter = true;
                            }
                        }

                    }
                    else
                    {
                        newLamps.Add(lamps[i]);
                    }
                }

                if ((newLamps.Count == 0))
                {
                    break;
                }
                lamps = newLamps;
                during++;
            }

            return lamps[0];
             */
        }
        static int GCD(int x, int y)
        {
            int temp;
            while (y != 0)
            {
                temp = x;
                x = y;
                y = temp % y;
            }
            return x;
             
        }
    }
}