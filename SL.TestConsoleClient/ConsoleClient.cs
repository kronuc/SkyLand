using SL.Time;
using SL.Time.Services;
using SL.Time.Services.Abstracion;
using System;

namespace SL.TestConsoleClient
{
    public class ConsoleClient
    {
        public ConsoleClient()
        {
        }

        public void Start()
        {

            Console.WriteLine("Hello World!");
            ITimeService ts = TimeServiceFactory.GetTimeService();
            ts.TimeChangedEvent += TestEventHandler;
            ts.TimerSpeed = GameTimerSpeed.Medium;
            ts.Start();
        }
        public void TestEventHandler(object sender, TimeChangedEventArgs args)
        {
            Console.WriteLine(args.CurrentTime);
        }
    }
}
