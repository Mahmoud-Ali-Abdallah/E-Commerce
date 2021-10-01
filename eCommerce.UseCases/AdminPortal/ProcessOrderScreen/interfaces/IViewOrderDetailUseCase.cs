using eCommerce.CoreBusiness.Models;

namespace eCommerce.UseCases.AdminPortal.ProcessOrderScreen
{
    public interface IViewOrderDetailUseCase
    {
        Order Execute(int orderId);
    }
}