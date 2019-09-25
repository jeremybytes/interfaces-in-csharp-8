using System.Collections.Generic;
using System.Linq;

namespace DangerousAssumptions.SlowPerformance
{
    public interface IReader<T>
    {
        IReadOnlyCollection<T> GetItems();

        // Default implementation like this makes assumptions
        // about the underlying implementation.
        // It also requires that *all* items are generated.
        T GetItemAt(int index) => GetItems().ElementAt(index);
    }
}
