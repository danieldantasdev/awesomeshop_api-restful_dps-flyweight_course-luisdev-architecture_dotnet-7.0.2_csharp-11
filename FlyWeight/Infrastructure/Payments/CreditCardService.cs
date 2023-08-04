using FlyWeight.Application.Models;

namespace FlyWeight.Infrastructure.Payments;

public class CreditCardService : IPaymentService
{
    public object Process(OrderInputModel model)
    {
        return "Transação aprovada";
    }
}