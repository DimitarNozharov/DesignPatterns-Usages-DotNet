using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
	internal class Espresso : Bevarage
	{
		public Espresso(string description) 
		{
			this.description = description;
		}

		public override double Cost() => 1.99;
	}
}
