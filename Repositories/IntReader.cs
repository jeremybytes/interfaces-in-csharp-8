using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class IntReader : IReader<int>
    {
        IReadOnlyCollection<int> IReader<int>.GetItems()
        {
            return new List<int> { 1, 2, 3 };
        }

        public int GetItem(int id)
        {
            return id;
        }
    }
}
