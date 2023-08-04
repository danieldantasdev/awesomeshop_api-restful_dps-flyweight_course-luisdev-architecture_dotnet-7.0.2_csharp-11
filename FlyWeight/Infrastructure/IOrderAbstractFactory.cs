using FlyWeight.Core.Enums;
using FlyWeight.Infrastructure.Deliveries;
using FlyWeight.Infrastructure.Payments;

namespace FlyWeight.Infrastructure;

public interface IOrderAbstractFactory
{
    IPaymentService GetPaymentService(PaymentMethod method);
    IDeliveryService GetDeliveryService();
}