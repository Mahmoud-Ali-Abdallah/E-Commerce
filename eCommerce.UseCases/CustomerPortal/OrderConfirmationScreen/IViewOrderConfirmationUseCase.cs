using eCommerce.CoreBusiness.Models;

namespace eCommerce.UseCases.OrderConfirmationScreen
{
    public interface IViewOrderConfirmationUseCase
    {
        Order Execute(string uniqueId);
    }
}