# ElevatorSimulator

# Elevator Simulator

## Overview

Elevator Simulator is a C# console application that simulates the operation of elevators in a multi-story building. This project demonstrates the use of Object-Oriented Programming (OOP), SOLID principles, and incorporates error handling and input validation.

## Features

- Simulate multiple elevators in a building with a customizable number of floors
- Real-time display of elevator statuses
- Random generation of elevator requests
- Implementation of basic elevator logic (moving up, down, idle)

## Requirements

- .NET 6 SDK
- Any text editor or IDE that supports C# development (e.g., Visual Studio, Visual Studio Code)

## Installation

1. Ensure you have the .NET 6 SDK installed on your system.
2. Clone this repository or download the source code.
3. Open a terminal and navigate to the project directory.

## Usage

1. Build the project:
   ```
   dotnet build
   ```

2. Run the application:
   ```
   dotnet run
   ```

3. Follow the on-screen instructions:
   - The simulation will display the current status of all elevators.
   - Random elevator requests will be generated.
   - Press any key to advance the simulation.
   - Press 'Q' to quit the application.

## Project Structure

- `Program.cs`: Contains the main entry point and core logic for the simulator.
- `Building.cs`: Represents the building with elevators.
- `Elevator.cs`: Represents an individual elevator and its operations.
- `ElevatorState.cs`: Enum defining possible states of an elevator.
- `Simulator.cs`: Handles the simulation logic and user interface.

## Contributing

Contributions to improve the Elevator Simulator are welcome. Please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Commit your changes with clear, descriptive messages.
4. Push your branch and submit a pull request.

## License

This project is open-source and available under the MIT License.

## Contact

For any questions or feedback, please open an issue in the GitHub repository.