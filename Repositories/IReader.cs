using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface IReader<T>
    {
        protected IReadOnlyCollection<T> GetItems();
        abstract T GetItem(int id);

        private void Save(T item) => Console.Write(item.ToString());
    }
}
