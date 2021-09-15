using SL.Time.GameTimer;
using SL.Time.GameTimer.Abstraction;
using SL.Time.Services.Abstracion;
using SL.Time.Services.Realisation;
using SL.Time.Services.Realisation.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Time.Services
{
    public class TimeServiceFactory
    {
        public static ITimeService GetTimeService()
        {
            GameTimerBase timer = GameTimerFactory.GetTimer();
            return new SimpleTimeService(timer);
        }

    }
}
