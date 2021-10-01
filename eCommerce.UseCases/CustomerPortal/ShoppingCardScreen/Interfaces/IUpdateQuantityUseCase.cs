using eCommerce.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eCommerce.UseCases.ShoppingCardScreen
{
    public interface IUpdateQuantityUseCase
    {
        Task<Order> Execute(int productId, int quantity);
    }
}