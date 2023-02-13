using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.StepwiseBuilderPattern
{
	public class CarBuilder
	{
		//a private class for all interfaces to not be abble to call from outside (making the builder private)
		//alternative: CardBuilder can be put inside the car class
		private class Impl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
		{
			private Car car = new Car();

			//step 1
			ISpecifyWheelSize ISpecifyCarType.OfType(CarType carType)
			{
				car.Type = carType;
				return this; //ISpecifyWheelSize -> enforce to call only  ISpecifyWheelSize.WithWheels()
			}

			//step 2
			IBuildCar ISpecifyWheelSize.WithWheels(int size)
			{
				switch (car.Type)
				{
					case CarType.Crossover when size < 17 || size > 20:
					case CarType.Crossover when size < 15 || size > 17:
						throw new ArgumentException($"Wrong size of wheel for {car.Type}");
				}

				car.WheelSize = size;
				return this;  //IBuildCar -> enforce to call only IBuildCar.Build()
			}

			// step 3
			Car IBuildCar.Build()
			{
				return car;
			}

		} //end private class

		public static ISpecifyCarType Create()
		{
			return new Impl(); //ISpecifyCarType -> OfType is the only allowed method to be called next
		}
	}
}