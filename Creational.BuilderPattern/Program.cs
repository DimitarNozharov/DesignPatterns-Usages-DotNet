using Creational.BuilderPattern;
using System.Text;

public class Program
{
	public static void Main(string[] args) 
	{
		BeforeBuilder();

		//After builder
		Console.WriteLine("\r\n--- After builder ---");
		var builder = new HtmlBuilder("ul");
		builder.AddChild("li", "hello");
		builder.AddChild("li", "world");
		Console.WriteLine(builder);

	}

	public static void BeforeBuilder()
	{
		var hello = "hello";
		var sb = new StringBuilder();
		sb.Append("<p>");
		sb.Append(hello);
		sb.Append("</p>");
		Console.WriteLine(sb);

		var words = new[] { "hello", "world" };
		sb.Clear();
		sb.Append("<ul>");
		foreach (var word in words)
		{
			sb.AppendFormat($"<li>{word}</li>");
		}
		sb.Append("</ul>");

		Console.WriteLine(sb);

	}
}