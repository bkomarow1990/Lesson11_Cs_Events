using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Task2
{
    //class FinishArgs : EventArgs { 

    //}
    abstract class Car
    {
        public string Name { get; protected set; }
        Random rnd = new Random();
        public delegate void Finish(string name);
        public delegate void Move(string name, int x);
        public event Finish Finished;
        public event Move Moved;
        public int x;
        public int X
        {
            get => x;
            set
            {
                x = value;
            }
        }
        public byte speed;
        public byte Speed { get => speed; }


        public void Go()
        {
            speed = (byte)rnd.Next(0, 11);
            if (X + speed >= 100)
            {
                Moved?.Invoke(Name, X);
                Finished?.Invoke(Name);

                X = 100;
            }
            else
            {
                X += speed;
                Moved?.Invoke(Name, X);
                Go();
            }

        }
        public Car()
        {
        }
    }
    class Lorry : Car
    {
        public Lorry()
        {
            this.Name = "Lorry";
        }
    }
    class Racing : Car
    {
        public Racing()
        {
            this.Name = "Racing";
        }
    }
    class Bus : Car
    {
        public Bus()
        {
            this.Name = "Bus";
        }
    }
}