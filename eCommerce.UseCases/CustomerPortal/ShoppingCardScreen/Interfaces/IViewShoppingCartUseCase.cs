using eCommerce.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eCommerce.UseCases.ShoppingCardScreen
{
    public interface IViewShoppingCartUseCase
    {
        Task<Order> Execute();
    }
}