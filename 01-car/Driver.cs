using System;

namespace Metropolia.Games
{
	public class Driver
	{
		private Car myCar;

		public Driver(Car myCar)
		{
			this.myCar = myCar;
		}

		public void Drive()
		{
			myCar.FillTank();

			//Accelerates car until speed is 50 or gas tank is empty
			while ((myCar.GetSpeed() < 50.0) && (myCar.GetGasLevel() >= 0.1))
			{
				myCar.Accelerate();
			}

			//Decelerates car until the speed is 0
			while (myCar.GetSpeed() > 0)
			{
				myCar.Decelerate();
			}

		}

	}
}