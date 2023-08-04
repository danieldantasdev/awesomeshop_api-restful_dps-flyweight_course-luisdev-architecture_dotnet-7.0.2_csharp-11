using FlyWeight.Application.Models;

namespace FlyWeight.Infrastructure.Deliveries;

public interface IDeliveryService
{
    void Deliver(OrderInputModel model);
}