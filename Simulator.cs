namespace ElevatorSimulator
{
    public class Simulator
    {
        private readonly Building _building;
        private readonly Random _random = new Random();

        public Simulator(Building building)
        {
            _building = building ?? throw new ArgumentNullException(nameof(building));
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                DisplayStatus();
                SimulateElevatorMovement();
                GenerateRandomRequest();

                Console.WriteLine("\nPress any key to continue simulation or 'Q' to quit.");
                if (Console.ReadKey(true).Key == ConsoleKey.Q)
                    break;
            }
        }

        private void DisplayStatus()
        {
            Console.WriteLine($"Building Status (Floors: {_building.Floors})");
            foreach (var elevator in _building.Elevators)
            {
                Console.WriteLine($"Elevator {elevator.Id}: Floor {elevator.CurrentFloor} - {elevator.State}");
            }
        }

        private void SimulateElevatorMovement()
        {
            foreach (var elevator in _building.Elevators)
            {
                elevator.Move();
            }
        }

        private void GenerateRandomRequest()
        {
            var elevator = _building.Elevators[_random.Next(_building.Elevators.Count)];
            var targetFloor = _random.Next(1, _building.Floors + 1);

            try
            {
                elevator.SetDestination(targetFloor);
                Console.WriteLine($"\nNew request: Elevator {elevator.Id} to floor {targetFloor}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
        }
    }
}