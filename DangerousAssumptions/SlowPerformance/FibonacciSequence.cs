using System.Collections;
using System.Collections.Generic;

namespace DangerousAssumptions.SlowPerformance
{
    public class FibonacciSequence : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            var value = (current: 0, next: 1);

            bool notOverflowed = true;
            while (notOverflowed)
            {
                value = (value.next, value.current + value.next);
                if (value.next < 0)
                {
                    // this denotes that the integer field
                    // has overflowed.
                    notOverflowed = false;
                }
                yield return value.current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
