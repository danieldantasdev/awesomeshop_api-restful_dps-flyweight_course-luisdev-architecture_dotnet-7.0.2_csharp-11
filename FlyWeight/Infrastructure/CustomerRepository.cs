using FlyWeight.Core.Entities;

namespace FlyWeight.Infrastructure;

public class CustomerRepository : ICustomerRepository
{
    public List<Customer> GetBlockedCustomers()
    {
        return new List<Customer>
        {
            new("Fulano", DateTime.Now.AddYears(-20)),
            new("Fulano", DateTime.Now.AddYears(-30)),
            new("Fulano", DateTime.Now.AddYears(-40))
        };
    }
}