using System;
using System.Linq;
using Cooking;
namespace RefactorIfStatement
{
    class RefactorIfStatement
    {
        static void FirstIfStatement()
        {
            Potato potato;
            //... 
            if (potato != null)
            {
                if (potato.HasBeenPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
        }
        static void SecondIfStatemnt()
        { 
            bool xIsInInterval = MIN_X <= x && x <= MAX_X;
            bool yIsInInterval = MIN_Y <= y && y <= MAX_Y;

            if ( xIsInInterval && yIsInInterval && shouldVisitCell )
            {
               VisitCell();
            }
        }
    }
}
