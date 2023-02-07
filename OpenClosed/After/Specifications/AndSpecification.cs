using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.After.Specifications
{
	public class AndSpecification<T> : ISpecification<T>
	{
		ISpecification<T> firstSpec, secondSpec;

		public AndSpecification(ISpecification<T> firstSpec, ISpecification<T> secondSpec)
		{
			this.firstSpec = firstSpec ?? throw new ArgumentNullException(paramName: nameof(firstSpec));
			this.secondSpec = secondSpec ?? throw new ArgumentNullException(paramName: nameof(secondSpec));
		}

		public bool IsSatisfied(T item)
		{
			return firstSpec.IsSatisfied(item) && secondSpec.IsSatisfied(item);
		}
	}
}
