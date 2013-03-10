using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static void Main()
        {
            int[] numbers = new int[5];
            int[] bits = { 7, 11, 13, 14, 19, 21, 22, 25, 26, 28 };
            int[] whereThe1bitsAre = new int[3];
            int theBit, MinLCM=0, currLCM;
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                int counter = 0;
                for (int j = 0; j < 5; j++)                 //Gets the places of bits equal to 1 in the current number bits[i]
                {
                    theBit = ((bits[i] & (1 << j)) >> j);
                    if (theBit == 1)
                    {
                        whereThe1bitsAre[counter] = j;
                        counter++;
                    }
                    if (counter == 3) break;
                }
                currLCM = LCM(numbers[whereThe1bitsAre[0]], numbers[whereThe1bitsAre[1]], numbers[whereThe1bitsAre[2]]);
                if (currLCM < MinLCM || MinLCM == 0)
                {
                    MinLCM = currLCM;
                }
            }
            Console.WriteLine(MinLCM);
        }
        private static int LCM(int p1, int p2, int p3)
        {
            int myLCM=1;
            int devisor = 2;
            bool devisable;
            while (p1 != 1 || p2 != 1 || p3 != 1)
            { 
                devisable=false;
                if (p1 % devisor == 0)
                {
                    p1 /= devisor;
                    devisable = true;
                }
                if (p2 % devisor == 0)
                {
                    p2 /= devisor;
                    devisable = true;
                }
                if (p3 % devisor == 0)
                {
                    p3 /= devisor;
                    devisable = true;
                }
                if (devisable)
                {
                    myLCM *= devisor;
                }
                else
                {
                    devisor++;
                }
            }
            return myLCM;
        }
    }
}
