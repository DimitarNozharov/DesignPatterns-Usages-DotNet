using Creational.StepwiseBuilderPattern;

public class Program
{

	public static void Main(string[] args)
	{
		var car = CarBuilder
			.Create()				//ISpecifyCarType
			.OfType(CarType.Sedan)	//ISpecifyWheelSize
			.WithWheels(4)			//IBuildCar
			.Build();

		Console.WriteLine(car);
	}
}