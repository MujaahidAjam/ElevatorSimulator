namespace ElevatorSimulator
{
    public class Building
    {
        public List<Elevator> Elevators { get; }
        public int Floors { get; }

        public Building(int elevatorCount, int floors)
        {
            if (elevatorCount <= 0) throw new ArgumentException("Elevator count must be positive.", nameof(elevatorCount));
            if (floors <= 1) throw new ArgumentException("Floor count must be greater than 1.", nameof(floors));

            Elevators = Enumerable.Range(0, elevatorCount).Select(i => new Elevator(i + 1, floors)).ToList();
            Floors = floors;
        }
    }
}