﻿
namespace BehaviourPatterns.StatePattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//client code
			var context = new Context(new ConcreteStateA());
			context.Request1();
			context.Request2();
		}
	}
}