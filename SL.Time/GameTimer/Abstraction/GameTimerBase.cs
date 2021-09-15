using System;
using System.Threading;

namespace SL.Time.GameTimer.Abstraction
{
    internal abstract class GameTimerBase
    {
        public int CurrentTime { get; private set; }
        public GameTimerStatus Status { get; set; }
        public GameTimerSpeed Speed { get; set; }
        public abstract event EventHandler<TimeChangedEventArgs> TimeChangedEvent;

        protected int _currentTime;
        protected bool _isUpdated;

        public abstract void Start();

        internal GameTimerBase()
        {
            _isUpdated = false;
            Status = GameTimerStatus.Paused;
            _currentTime = 0;
        }

        
        
    }

    
}
