using System;
using System.Collections.Generic;
using System.Text;

namespace ClockHW
{
    class MyArgs : EventArgs {
        private byte hour;
        private byte minute;
        public byte Hour
        {
            get => hour;
            set
            {
                if (value >= 24)
                {
                    this.hour = 0;
                }
                this.hour = value;
            }
        }
        public byte Minute
        {
            get => minute;
            set
            {
                if (value >= 60)
                {
                    this.minute = 0;
                }
            }
        }
        public MyArgs(byte hour, byte minute)
        {
            Hour = hour;
            Minute = minute;
        }
    }
    class Clock
    {
        public event EventHandler AlarmClock;
        private byte hour;
        private byte alarm_hour;
        private byte minute;
        private byte alarm_minute;
        
        public byte Hour {
            get => hour;
            set {
                if (value >= 24)
                {
                    this.hour = 0;
                    return;
                }
                this.hour = value;
            }
        }
        public byte Minute {
            get => minute;
            set {
                if (value >= 60)
                {
                    this.minute = 0;
                    return;
                }
                this.minute = value;
            }
        }
        public byte AlarmHour
        {
            get => alarm_hour;
            set
            {
                if (value >= 24)
                {
                    this.alarm_hour = 0;
                }
                this.alarm_hour = value;
            }
        }
        public byte AlarmMinute
        {
            get => alarm_minute;
            set
            {
                if (value >= 60)
                {
                    this.alarm_minute = 0;
                    return;
                }
                this.alarm_minute = value;
            }
        }
        private bool HaveAlarm { get; set; }
        public void Tick() {
            ++Minute;

            if (Minute == AlarmMinute && Hour == AlarmHour && HaveAlarm == true)
            {
                AlarmClock?.Invoke(this, EventArgs.Empty);

            }
            else {
                Console.WriteLine(this);
            }
            
            

        }
        public Clock(byte hour, byte minute)
        {
            Hour = hour;
            Minute = minute;
        }
        public void SetAlarm(byte h, byte m) {
            this.AlarmHour = h;
            this.AlarmMinute = m;
            HaveAlarm = true;
        }
        public void CancelAlarm() {
            HaveAlarm = false;
        }
        public override string ToString()
        {
            return $"Now is: {Hour}: {People.ReadMinutes(Minute)}"; 
        }
    }
}
