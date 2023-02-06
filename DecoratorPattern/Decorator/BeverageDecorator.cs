using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
	abstract class BeverageDecorator : Bevarage
	{
		public abstract override double Cost();
		public abstract override string Description{ get; }
	}
}
