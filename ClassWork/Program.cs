using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            WarmHouse wh = new WarmHouse(-5, 20, 30);
            
            Console.WriteLine($"Now temp: {wh.Temp}");
            
        }
    }
}
