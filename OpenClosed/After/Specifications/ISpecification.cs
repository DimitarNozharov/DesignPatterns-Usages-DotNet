using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.After.Specifications
{
    //Generic interface to check if a certain object satisfied the requirements
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
