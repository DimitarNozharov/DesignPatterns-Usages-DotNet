using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Before
{
    public class ProductFilter
	{
		//let's suppose we don't want ad-hoc queries on products
		
		//issue: everytime we need a new change, we have to modify the existing class
		//that should be only open for extension and closed for modification

		//solution: we introduce new interfaces that are open for extension
		public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
		{
			foreach (var p in products)
				if (p.Color == color)
					yield return p;
		}

		public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
		{
			foreach (var p in products)
				if (p.Size == size)
					yield return p;
		}

		public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color, Size size)
		{
			foreach (var p in products)
				if (p.Color == color && p.Size == size)
					yield return p;
		}
	}
}
