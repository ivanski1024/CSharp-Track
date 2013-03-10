using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterAttack
{
    class FighterAttack
    {
        static void Main()
        {
            int Left, Top, Right, Bottom, FX, FY, D;
            int dmg=0;
            int PX1 = int.Parse(Console.ReadLine()),
                PY1 = int.Parse(Console.ReadLine()),
                PX2 = int.Parse(Console.ReadLine()),
                PY2 = int.Parse(Console.ReadLine()); 
            if(PX1>=PX2)
            {
                Right=PX1;
                Left=PX2;
            }
            else
            {
                Right=PX2;
                Left=PX1;
            }

            if (PY1 >= PY2)
            {
                Top = PY1;
                Bottom = PY2;
            }
            else
            {
                Top = PY2;
                Bottom = PY1;
            }


            FX = int.Parse(Console.ReadLine());
            FY = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            FX+=D;
            if (FX >= Left && FX <= Right && FY >= Bottom && FY <= Top)
            {
                dmg += 100;
            }
            FX ++;
            if (FX >= Left && FX <= Right && FY >= Bottom && FY <= Top)
            {
                dmg += 75;
            }
            FX--;
            FY++;
            if (FX >= Left && FX <= Right && FY >= Bottom && FY <= Top)
            {
                dmg += 50;
            }
            FY -= 2;
            if (FX >= Left && FX <= Right && FY >= Bottom && FY <= Top)
            {
                dmg += 50;
            }
            Console.WriteLine("{0}%", dmg);
        }
    }
}
