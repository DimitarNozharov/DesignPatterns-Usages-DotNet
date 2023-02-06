using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
	internal class Mocha : BeverageDecorator
	{
		Bevarage bevarage;

		public Mocha(Bevarage bevarage)
		{
			this.bevarage = bevarage;
		}

		public override string Description => bevarage.Description + ",Mocka";

		public override double Cost()
		{
			var initialCost =  bevarage?.Cost() ?? 0;
			return initialCost + 0.40;
		}

	}
}
