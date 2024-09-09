namespace ElevatorSimulator
{
    public class Elevator
    {
        public int Id { get; }
        public int CurrentFloor { get; private set; }
        public int DestinationFloor { get; private set; }
        public ElevatorState State { get; private set; }
        private readonly int _maxFloor;

        public Elevator(int id, int maxFloor)
        {
            Id = id;
            _maxFloor = maxFloor;
            CurrentFloor = 1;
            DestinationFloor = 1;
            State = ElevatorState.Idle;
        }

        public void SetDestination(int floor)
        {
            if (floor < 1 || floor > _maxFloor)
                throw new ArgumentOutOfRangeException(nameof(floor), $"Floor must be between 1 and {_maxFloor}.");

            DestinationFloor = floor;
            State = CurrentFloor < floor ? ElevatorState.MovingUp :
                    CurrentFloor > floor ? ElevatorState.MovingDown : ElevatorState.Idle;
        }

        public void Move()
        {
            if (State == ElevatorState.MovingUp && CurrentFloor < DestinationFloor)
                CurrentFloor++;
            else if (State == ElevatorState.MovingDown && CurrentFloor > DestinationFloor)
                CurrentFloor--;

            if (CurrentFloor == DestinationFloor)
                State = ElevatorState.Idle;
        }
    }
}