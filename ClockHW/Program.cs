using System;

namespace ClockHW
{
    class Program
    {
        static void Main(string[] args)
        {
            People boris = new People();
            Clock clock = new Clock(16,51);
            clock.AlarmClock += boris.Handler;
            clock.SetAlarm(16, 58);
            for (int i = 0; i < 10; i++)
            {
                clock.Tick();
                //Console.WriteLine(clock);
            }
            
            
        }
    }
}
