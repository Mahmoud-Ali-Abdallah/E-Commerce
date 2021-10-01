using eCommerce.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eCommerce.UseCases.ShoppingCardScreen
{
    public interface IPlaceOrderUseCase
    {
        Task<string> Execute(Order order);
    }
}