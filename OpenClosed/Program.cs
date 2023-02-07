using OpenClosed.After.Filters;
using OpenClosed.After.Specifications;
using OpenClosed.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var apple = new Product("Apple", Color.Red, Size.Small);
			var orange = new Product("Orange", Color.Red, Size.Large);
			var house = new Product("House", Color.Blue, Size.Huge);
			var car = new Product("Car", Color.Green, Size.Large);

			var productFilter = new ProductFilter();
			Product[] products = new Product[] { apple, orange, house, car };

			//-------------- Before OCP	--------------
			var largeSize = productFilter.FilterBySize(products, Size.Large);

			foreach (var item in largeSize)
				Console.WriteLine($" - {item.Name} is Large.");

			//if we need to filter by other criteria - we have to change the existing ProductFilter class.
			//This can brake the existing code, need to retest it and we are not working with abstraction.

			//-------------- After OCP --------------
			var filter = new BetterFilter<Product>();
			largeSize = filter.Filter(products, new SizeSpecification(Size.Large));

			foreach (var item in largeSize)
				Console.WriteLine($" - {item.Name} is Large.");

			var largeSizeSpec = new SizeSpecification(Size.Large);
			var redColorSpec = new ColorSpecification(Color.Red);
			var resBySizeAndColor = filter.Filter(products, new AndSpecification<Product>(largeSizeSpec, redColorSpec));

			foreach (var item in resBySizeAndColor)
				Console.WriteLine($" - {item.Name} is Large and Red.");

			//if we need to filter by other criteria - we won't touch the existing classess.
			//we need to create a Specification class, an enum and use it.
		}
	}
}
