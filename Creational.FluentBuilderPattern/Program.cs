using Creational.FluentBuilderPattern;

public class Program
{
	public static void Main(string[] args)
	{
		//var builder = new PersonJobBuilder();
		//builder.Called("Dimitar");	//PersonInfoBuilder.Called();

		//issue -> we don't have WorkAsA("...")
		//PersonInfoBuilder doesnt know anything about WorkAsA()
		//Question: how can a derived class propagate the type to return to its own base class

		//After the pattern

		//Builder ->
		//	PersonJobBuilder<Builder> ->
		//		PersonInfoBuilder<PersonJobBuilder<Builder> ->
		//			PersonBuilder

		PersonJobBuilder<Person.Builder> person = Person.New
						.Called("Dimitar");
					  //.WorksAsA("programmer")
					  //.Build();

		Console.WriteLine(person);

		var me = Person.New
					  .Called("Dimitar")
						.WorksAsA("programmer")
						.Build();

		Console.WriteLine(me);

	}
}