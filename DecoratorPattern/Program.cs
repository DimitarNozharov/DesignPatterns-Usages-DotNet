using DecoratorPattern;
using DecoratorPattern.Decorator;

public class Program
{
	public static void Main(string[] args)
	{
		var bevarage = new Espresso("Espresso1");

		Console.WriteLine(bevarage.Description);
		Console.WriteLine(bevarage.Cost());
		var mocha = new Mocha(bevarage);

		Console.WriteLine(mocha.Description);
		Console.WriteLine(mocha.Cost());
	}
}