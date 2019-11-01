using System.Collections.Generic;

namespace AccessModifiers.Public
{
    public interface ICustomerReader
    {
        // Interface members default to "public"
        // Both of these members are "public"
        IReadOnlyCollection<Customer> GetCustomers();
        public Customer GetCustomer(int Id);
    }
}
