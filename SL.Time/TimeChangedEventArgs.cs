using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Time
{
    public class TimeChangedEventArgs
    {
        public TimeChangedEventArgs(int currentTime)
        {
            CurrentTime = currentTime;
        }

        public int CurrentTime { get; private set; }
    }
}
