using System;
class TheSpiralOfNumbers
{
    public struct direction
    {
        public int x, y;
        public direction(int cX, int cY)
        {
            this.x = cX;
            this.y = cY;
        }
    }
    static readonly direction[] dir = new direction[4] 
    { 
        new direction(1, 0), 
        new direction(0, 1),
        new direction(-1, 0), 
        new direction(0, -1) 
    };
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[,] myArr = new int[n, n];
        myArr[0, 0] = 1;
        int i = 2;
        direction p = new direction(0, 0);
        int currDir = 0;
        while (i <= n * n)
        {
            if ((p.x + dir[currDir].x >= 0) && (p.x + dir[currDir].x < n) &&
                (p.y + dir[currDir].y >= 0) && (p.y + dir[currDir].y < n))
            {
                if (myArr[p.x + dir[currDir].x, p.y + dir[currDir].y] == '\0')
                {
                    p.x += dir[currDir].x;
                    p.y += dir[currDir].y;
                    myArr[p.x, p.y] = i;
                    i++;
                }
                else
                {
                    if (currDir == 3)
                        currDir = 0;
                    else
                        currDir++;
                }
            }
            else
            {
                if (currDir == 3)
                    currDir = 0;
                else
                    currDir++;
            }
        }
        for (int t = 0; t < n; t++)
        {
            for (int q = 0; q < n; q++)
            {
                if (n <= 3)
                {
                    Console.Write("{0} ", myArr[q, t]);
                }
                else if (n < 10)
                    Console.Write("{0, 2} ", myArr[q, t]);
                else
                    Console.Write("{0, 3} ", myArr[q, t]);
            }
            Console.WriteLine();
        }
    }
}
