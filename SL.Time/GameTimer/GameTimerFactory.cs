using SL.Time.GameTimer.Abstraction;
using SL.Time.GameTimer.Realisation.TimerOnThread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Time.GameTimer
{
    internal class GameTimerFactory
    {
        internal static GameTimerBase GetTimer()
        {
            return new GameTimerOnThreads();
        }
    }
}
