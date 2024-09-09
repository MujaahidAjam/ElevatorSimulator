using System;
using System.Collections.Generic;
using System.Linq;

namespace ElevatorSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Elevator Simulator!");

            var building = new Building(3, 10); // 3 elevators, 10 floors
            var simulator = new Simulator(building);
            simulator.Run();
        }
    }
}