using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerDelegates
{
    class TimerDelegates
    {
        static void PrintTime(string text)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("{0}:{1}:{2} {3}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, text);
        }
        static void Main()
        {
            Timer ticTimer = new Timer( new Timer.timerDelegate(PrintTime), "Tic", 2);
            Timer tacTimer = new Timer(new Timer.timerDelegate(PrintTime), "Tac", 2, 0.5);
        }
    }
}
