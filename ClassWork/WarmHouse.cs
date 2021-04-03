using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    delegate void WarmHouseDeleg(WarmHouse house);
    class WarmHouse
    {
        public readonly int MinTemp;
        public readonly int MaxTemp;
        public event WarmHouseDeleg TooHot;
        public event WarmHouseDeleg TooCold;
        public event WarmHouseDeleg Well;
        private Heater heater = new Heater();
        private Cooler cooler = new Cooler();
        private NormChecker normal = new NormChecker();
        public int temp;
        public int Temp {
            get => temp;
            set
            {
                if (value < MinTemp)
                {
                    
                    this.temp = value;
                    Console.WriteLine($"Too Cold, Now temp: {temp}");
                    this.TooCold?.Invoke(this);
                    
                    return;
                }
                else if (value > MaxTemp)
                {
                   
                    this.temp = value;
                    Console.WriteLine($"Too Cold, Now temp: {temp }");
                    this.TooHot?.Invoke(this);
                    
                    return;
                }
                this.temp = value;
                this.Well?.Invoke(this);
                
            }
        }
        public WarmHouse(int MinTemp, int MaxTemp, int temp)
        {
            TooCold += this.heater.Warm;
            TooHot += this.cooler.Cool;
            Well += this.normal.Normal;
            this.MinTemp = MinTemp;
            this.MaxTemp = MaxTemp;
            Temp = temp;
            
        }
    }
    class Heater
    {

        public void Warm(WarmHouse h) {
            h.Temp += 5;
        }
    }
    class Cooler
    {
        public void Cool(WarmHouse h)
        {
            h.Temp -= 5;
        }
    }
    class NormChecker
    {
        public void Normal(WarmHouse h)
        {
            Console.WriteLine($"Temperature is normal: {h.Temp}");
        }
    }
}
