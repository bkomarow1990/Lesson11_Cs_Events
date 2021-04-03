using System;
using System.Collections.Generic;
using System.Text;

namespace ClockHW
{
    class People
    {
        public static string ReadMinutes(byte minutes) {
            string m=String.Empty;
            if (minutes < 10)
            {
                m += "0";
            }

            return m += minutes.ToString();
        }
        public void Handler(object sender,EventArgs args) {
            if (sender == null)
            {
                return;
            }
            if (sender is Clock)
            {
                Clock cl = (Clock)sender;
                Console.WriteLine($"Alarm!!!\a\a\aNow is {cl.Hour}:{ReadMinutes(cl.Minute)}");
            }
            
        }
    }
}
