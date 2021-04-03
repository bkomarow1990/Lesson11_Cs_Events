using System;
using System.Collections.Generic;

namespace HW_Task2
{
    class Program
    {
        class Game {
            public List<Car> cars = new List<Car>();
            public void StartGame() {
                foreach (var item in cars)
                {
                    item.Finished += this.FinishedHandler;
                    item.Moved += this.MoveHandler;
                }
                foreach (var item in cars)
                {
                    item.Go();
                }
            }
            public void MoveHandler(string name,int x)
            {
                Console.WriteLine($"Car with name: {name} has been moved to coord: {x}");
            }
            public void FinishedHandler(string name) {
                Console.WriteLine($"Car with name : {name} is finished");
            }
        }

        static void Main(string[] args)
        {
            Car bmw = new Racing();
            Game game = new Game();
            game.cars.Add(bmw);
            game.cars.Add(new Racing());
            game.cars.Add(new Bus());
            game.StartGame();
            
        }
    }
}
