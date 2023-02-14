using Creational.FacetedBuilderPattern;

namespace Creational.FacetedBuilderPattern.Client;
public class Program
{
	public static void Main(string[] args)
	{
		var personBuilderFacade = new PersonBuilderFacade();
		Person person = personBuilderFacade
			.Lives
				.UnderName("Dimitar")  
				.InCity("Sofia")       
				.InCountry("Bulgaria")  
			.Work
				.As("Developer")   
				.Experience(10)    
				.Earning(100000);  
		
		Console.WriteLine(person + "\r\n");

		var otherPerson = new PersonBuilderFacade()
			.Lives
				.UnderName("Ivan")
				.InCity("Paris")
				.InCountry("France")
			.Work
				.As("Police Officer")
				.Experience(13)
				.Earning(85000).Build();

		Console.WriteLine(otherPerson);
	}
}