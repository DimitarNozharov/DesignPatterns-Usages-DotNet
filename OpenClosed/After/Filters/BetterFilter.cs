using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosed.After.Specifications;

namespace OpenClosed.After.Filters
{
    public class BetterFilter<T> : IFilter<T> where T : class
    {
        public IEnumerable<T> Filter(IEnumerable<T> input, ISpecification<T> specification)
        {
            foreach (var item in input)
            {
                if (specification.IsSatisfied(item))
                    yield return item;
            }
        }
    }
}
