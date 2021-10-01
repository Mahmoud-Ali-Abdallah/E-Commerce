using eCommerce.CoreBusiness.Models;
using System.Threading.Tasks;

namespace eCommerce.UseCases.ShoppingCardScreen
{
    public interface IDeleteProductUseCase
    {
        Task<Order> Execute(int productId);
    }
}