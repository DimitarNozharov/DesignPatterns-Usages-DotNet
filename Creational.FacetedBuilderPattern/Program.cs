using Creational.FacetedBuilderPattern;

public class Program
{
	public static void Main(string[] args)
	{
		var personBuilderFacade = new PersonBuilderFacade();
		Person person = personBuilderFacade
			.Lives
				.UnderName("Dimitar")	 //name
				.In("Sofia")			//city
				.InCountry("Bulgaria") //country
			.Work
				.As("Developer") //position
				.Experience(10)	    //experience
				.Earning(100000);  //salary

		Console.WriteLine(person);
	}
}