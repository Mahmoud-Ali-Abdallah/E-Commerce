using eCommerce.CoreBusiness.Models;
using eCommerce.UseCases.PluginInterfaces.StateStore;
using eCommerce.UseCases.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.UseCases.ShoppingCardScreen
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public DeleteProductUseCase(IShoppingCart shoppingCart, IShoppingCartStateStore shoppingCartStateStore)
        {
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }
        public async Task<Order> Execute(int productId)
        {
            var order = await shoppingCart.DeleteProductAsync(productId);
            shoppingCartStateStore.UpdateLineItemsCount();

            return order;
        }
    }
}
