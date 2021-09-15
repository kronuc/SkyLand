using SL.Time.GameTimer.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SL.Time.GameTimer.Realisation.TimerOnThread
{
    internal class GameTimerOnThreads : GameTimerBase
    {
        public GameTimerOnThreads()
        {
            
        }

        public override event EventHandler<TimeChangedEventArgs> TimeChangedEvent;

        public override void Start()
        {
           Status = GameTimerStatus.Work;
            bool stopFlag = true;
            while (stopFlag)
            {
                if (!_isUpdated && Status != GameTimerStatus.Paused)
                {
                    _currentTime++;
                    TimeChangedEvent?.Invoke(null, new TimeChangedEventArgs(_currentTime));
                    _isUpdated = true;
                }
                else
                {
                    switch (Speed)
                    {
                        case GameTimerSpeed.High:
                            _isUpdated = false;
                            break;
                        case GameTimerSpeed.Medium:
                            Thread.Sleep(1000);
                            _isUpdated = false;
                            break;
                        case GameTimerSpeed.Low:
                            Thread.Sleep(3000);
                            _isUpdated = false;
                            break;
                        default:
                            _isUpdated = false;
                            break;
                    }
                }
                if (Status == GameTimerStatus.Stopped)
                    stopFlag = false;
            }
        }
    }
}
