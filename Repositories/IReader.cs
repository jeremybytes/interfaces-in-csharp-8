using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface IReader<T>
    {
        protected IReadOnlyCollection<T> GetItems();
        abstract T GetItem(int id);

        // Note: "Save" is not an appropriate method for a reader
        // interface. This was just experimenting with the syntax
        private void Save(T item) => Console.Write(item.ToString());
    }
}
