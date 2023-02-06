using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns.StatePattern
{
	internal class ConcreteStateA : State
	{
		public override void Handle1()
		{
			Console.WriteLine("ConreteStateA handles the request1.\r\nConreteStateA wants to change the state of the context.");
			_context.TransitionTo(new ConcreteStateB());
		}

		public override void Handle2()
		{
			Console.WriteLine("ConcreteStateA handles request2.");
		}
	}
}
