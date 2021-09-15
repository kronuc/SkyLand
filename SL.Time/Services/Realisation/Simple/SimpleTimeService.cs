using SL.Time.GameTimer;
using SL.Time.GameTimer.Abstraction;
using SL.Time.Services.Abstracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Time.Services.Realisation.Simple
{
    internal class SimpleTimeService : ITimeService
    {
        private GameTimerBase _timer;

        public SimpleTimeService(GameTimerBase timer)
        {
            _timer = timer;
        }

        public GameTimerSpeed TimerSpeed { get => _timer.Speed; set => _timer.Speed = value; }

        public event EventHandler<TimeChangedEventArgs> TimeChangedEvent
        {
            add { _timer.TimeChangedEvent += value; }
            remove { _timer.TimeChangedEvent -= value; }
        }

        public void Continue()
        {
            _timer.Status = GameTimerStatus.Work;
        }

        public int GetCurrentDate()
        {
            return _timer.CurrentTime;
        }

        public void Pause()
        {
            _timer.Status = GameTimerStatus.Paused;
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Status = GameTimerStatus.Stopped;
        }
    }
}
