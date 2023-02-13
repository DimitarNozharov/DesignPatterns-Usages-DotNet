using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.StepwiseBuilderPattern
{
	//Builder that first need to get to know the type and based on that to specify the wheelsize
	public enum CarType
	{
		Sedan,
		Crossover
	}
	public class Car
	{
		public CarType Type { get; set; }
		public int WheelSize { get; set; }

		public override string ToString() =>
			 $"{nameof(Type)} - {Type}, {nameof(WheelSize)} -  {WheelSize}";
	}

}
