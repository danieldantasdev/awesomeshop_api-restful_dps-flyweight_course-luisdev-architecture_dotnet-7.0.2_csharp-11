using FlyWeight.Core.Entities;

namespace FlyWeight.Infrastructure;

public interface ICustomerRepository
{
    List<Customer> GetBlockedCustomers();
}