using System.Collections.Generic;
using System.Linq;

namespace DangerousAssumptions.SlowPerformance
{
    public class FibonacciReader : IReader<int>
    {
        public IReadOnlyCollection<int> GetItems()
        {
            return new FibonacciSequence().ToList();
        }

        // Comment out this method to use the default implementation
        // from the interface
        public int GetItemAt(int index)
        {
            return new FibonacciSequence().ElementAt(index);
        }

    }


}
