using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Time.Services.Abstracion
{
    public interface ITimeService
    {
        public GameTimerSpeed TimerSpeed { get; set; }
        public void Start();
        public void Stop();
        public void Pause();
        public void Continue();
        public int GetCurrentDate();
        public event EventHandler<TimeChangedEventArgs> TimeChangedEvent;
    }
}
