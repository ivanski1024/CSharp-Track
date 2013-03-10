using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerDelegates
{
    class Timer
    {
        public delegate void timerDelegate(string text);
        public Timer(timerDelegate userMethod, string text, int seconds)
        {
            Thread newThread = new Thread(() =>
                {
                    while (true)
                    {
                        userMethod(text);
                        Thread.Sleep(seconds * 1000);
                    }
                });
            newThread.Start();
        }
        public Timer(timerDelegate userMethod, string text, int seconds, double firstPeriodLength)
        {
            bool first = true;
            Thread newThread = new Thread(() =>
                {
                    while (true)
                    {
                        if (first)
                        {
                            Thread.Sleep((int)(seconds * firstPeriodLength * 1000));
                            userMethod(text);
                            first = false;
                        }
                        else
                        {
                            Thread.Sleep(seconds * 1000);
                            userMethod(text);
                        }
                    }
                });
            newThread.Start();
        }
    }
}
