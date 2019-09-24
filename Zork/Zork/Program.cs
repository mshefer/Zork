using System;

namespace Zork
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Zork!");

			Commands command = Commands.UNKNOWN;
			while (command != Commands.QUIT)
			{
				Console.Write("> ");
				command = ToCommand(Console.ReadLine().Trim());

				string outputString;
				switch (command)
				{
					case Commands.QUIT:
						outputString = "Thank you for playing!";
						break;

					case Commands.LOOK:
						outputString = "This is an open field west of a qhite house, with a boarded front door.\nA rubber may saying 'Welcome to Zork!' lies by the door.";
						break;

					case Commands.NORTH:
					case Commands.SOUTH:
					case Commands.EAST:
					case Commands.WEST:
						outputString = $"You moved {command}";
						break;

					default:
						outputString = "Unknown command.";
						break;
				}

				Console.WriteLine(outputString);
			}
		}

		private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

		private static readonly string[,] Rooms = {
			{ "Rocky Trail", "South of House", "Canyon View" },
			{ "Forest", "West of House", "Behind House" },
			{"Dense Woods", "North of House", "Clearing" }
		};

	}
}
