using System;

namespace Lesson11_Cs_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer ann = new Customer { Name = "Ann" };
            
            Magazine magazine = new Magazine { Title= "Forbes"};
            magazine.NewPostAddedEvent += ann.Handler;
            magazine.AddPost("E.Mask became the richest man in the world");
            Console.WriteLine("Hello World!");
        }
    }
}
