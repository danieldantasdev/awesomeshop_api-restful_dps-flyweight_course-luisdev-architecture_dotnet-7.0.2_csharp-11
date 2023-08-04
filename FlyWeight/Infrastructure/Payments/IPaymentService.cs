using FlyWeight.Application.Models;

namespace FlyWeight.Infrastructure.Payments;

public interface IPaymentService
{
    object Process(OrderInputModel model);
}