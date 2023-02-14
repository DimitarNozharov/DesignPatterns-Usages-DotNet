using System;
using System.Text;
using System.Collections.Generic;

namespace CreationalPatterns.Exercises.CodeBuilder
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
			Console.WriteLine(cb);
		}
	}
}
