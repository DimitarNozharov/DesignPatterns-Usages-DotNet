using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
	internal class HouseBlend : Bevarage
	{
		public HouseBlend(string description)
		{
			this.description = description;
		}

		public override double Cost() => 0.89;
	}
}
