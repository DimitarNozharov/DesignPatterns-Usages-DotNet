using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.StepwiseBuilderPattern
{
	public interface ISpecifyCarType
	{
		ISpecifyWheelSize OfType(CarType carType);
	}
}
