using FlyWeight.Core.Enums;

namespace FlyWeight.Infrastructure.Payments;

public interface IPaymentServiceFactory
{
    IPaymentService GetService(PaymentMethod paymentMethod);
}