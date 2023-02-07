using OpenClosed.After.Specifications;

namespace OpenClosed.After.Filters
{
    //generic filter interface that can filter by many specifications without a need of change
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> input, ISpecification<T> specification);
    }
}