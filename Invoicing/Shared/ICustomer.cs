using System.Collections.Generic;

namespace Invoicing.Shared
{
    public interface ICustomer
    {
        IEnumerable<Customer> AllCustomers { get; }
    }
}
