using System;

namespace Metropolia.Games
{
	class MainClass
	{
		// Execution starts here.
		public static void Main(string[] args)
		{
			Car theCar = new Car();
			Driver theDriver = new Driver(theCar);

			theDriver.Drive();
		}
	}
}